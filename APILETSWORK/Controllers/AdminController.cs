using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILETSWORK.Models;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;

namespace APILETSWORK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly SignInManager<ApplicationUsers> _signInManager;
        private readonly UserManager<ApplicationUsers> userManager;
        private readonly IConfiguration configuration;


        public AdminController(SignInManager<ApplicationUsers> SM, UserManager<ApplicationUsers> UM ,IConfiguration IC)
        {
            this._signInManager = SM;
            this.userManager = UM;
            this.configuration = IC;

        }


        //Register

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> register([FromBody] Register register)
        {

            ApplicationUsers applicationUser = new ApplicationUsers()
            {
                Nom = register.Nom,
                Prenom = register.Prenom,
                Email = register.Email,
                UserName = register.Email,
                Adresse = register.Adresse,
                CodePostal = register.CodePostal,
                Ville = register.Ville,
                pays = register.Pays



            };


            var res = await userManager.CreateAsync(applicationUser, register.Password);



            return Ok(res);
        }



        // login

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] Auth model)
        {
            var user = await userManager.FindByNameAsync(model.Email);
            if (user != null && await userManager.CheckPasswordAsync(user, model.Motdepasse))
            {
                var userRoles = await userManager.GetRolesAsync(user);
                var authClaims = new List<Claim>
{
new Claim(ClaimTypes.Name, user.UserName),
new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
};
                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }
                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:SecretKey"]));
                var token = new JwtSecurityToken(
                issuer: configuration["JWT:ValidIssuer"],
                audience: configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();
        }









    }
}
