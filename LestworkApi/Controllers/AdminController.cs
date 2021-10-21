using LestworkApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LestworkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private DBcontext.LetsworkDbcontext LetsworkDbcontext;

        [HttpPost("Inscription")]


        public string InscriptionUser(ApplicationUser personne)
        {
            
           //   var persObj=new Personne() { Nom=personne.Nom,Prenom=personne.Prenom,}





            return null;

        }


        [HttpGet("Insc")]
        public string Insc()
        {
            try
            {
                string r = LetsworkDbcontext.Users.Select(s => s.Nom).ToString();
                return r;
            }
            catch (Exception ex)
            {

                return ex.Message;

            }
        }



        /*   if (ModelState.IsValid)
            {
                foreach (var file in files)
                {
                    //Checking file is available to save.  
                    if (file != null)
                    {
                        var InputFileName = Path.GetFileName(file.FileName);
                        var ServerSavePath = Path.Combine(Server.MapPath("~/StorageImage/"), InputFileName);
                        //Save file to server folder  

                        file.SaveAs(ServerSavePath);

                        imageProduit.Add(new ImageProduit { NomImage = InputFileName, PathImage = ServerSavePath, IdProduit = idproduit });

                    }
                }
                for (int i = 0; i < imageProduit.Count; i++)
                {
                    db.ImageProduit.Add(imageProduit[i]);
                    db.SaveChanges();
                }

            }
*/

        //public String Insciption(pers client)
        //{
        //    var clientins = new Client {
        //        Nom = client.Nom,
        //        Prenom = client.Prenom,
        //        Telephone = client.Telephone,
        //        Adresse = client.Adresse,
        //        CodePostal = client.CodePostal,
        //        Ville = client.Ville,
        //        Pays=client.Pays,
        //        DateNaissance=client.DateNaissance



        //    };

        //    LetsworkDbcontext.Add(client);

        //    LetsworkDbcontext.SaveChanges();




        //    return " bien ";






    }

}