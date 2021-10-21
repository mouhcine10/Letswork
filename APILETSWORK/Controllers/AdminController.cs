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
        private  UserManager<ApplicationUsers> _userManager;
        private readonly IConfiguration configuration;


        public AdminController(SignInManager<ApplicationUsers> SM, UserManager<ApplicationUsers> UM)
        {
            this._signInManager = SM;
            this._userManager = UM;


        }


        //Register

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> register(Register register)
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


            var res = await _userManager.CreateAsync(applicationUser, register.Password);



            return Ok(res);
        }



        // login

        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(Auth Auth)
        {
            string to = "";
            ApplicationUsers Usercheck= await _userManager.FindByEmailAsync(Auth.Email);

            var res = await _userManager.CheckPasswordAsync(Usercheck, Auth.Motdepasse);

            var userrole = await _userManager.GetRolesAsync(Usercheck);
            //to= generateJwtToken(Usercheck);
            var authClaim = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,Usercheck.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),

                };
            foreach (var d in userrole)
            {

                authClaim.Add(new Claim(ClaimTypes.Role, d));


            }

            var authSigninKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(

                issuer: configuration["JWT:ValidIssuer"],
                audience: configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaim,
                signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256)

                );
            to = new JwtSecurityTokenHandler().WriteToken(token);




            return Ok(new { token = to, User = Usercheck.Email });
        }








    }
}
