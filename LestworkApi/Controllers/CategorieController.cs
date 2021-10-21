using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LestworkApi.Models;
using Microsoft.EntityFrameworkCore;
using LestworkApi.DBcontext;

namespace LestworkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        private readonly LetsworkDbcontext LetsworkDbcontext;


        public CategorieController(LetsworkDbcontext letsworkDbcontext)
        {
            this.LetsworkDbcontext = letsworkDbcontext;
                
        }

        //Ajouter Categorier
        [HttpPost]
        public void CreationCategorie(Categorie categorie)
        {
            var Cat = new Categorie() { Id_Categorie = categorie.Id_Categorie, Nomcategorie = categorie.Nomcategorie, PhotoCatégorie = categorie.PhotoCatégorie };
            LetsworkDbcontext.Categorie.Add(Cat);
            LetsworkDbcontext.SaveChanges();


        }

        //Supprimer Categorier
        [HttpDelete]
        public string DeleteCategorie(string IdCategorie)
        {
            var cat = LetsworkDbcontext.Categorie.Find(IdCategorie);

           
                LetsworkDbcontext.Categorie.Remove(cat);

                return "Bien Supprimer";
           

        }

        [HttpPut]

        public string UpdateCategorier(int IdCategorie, Categorie categorie)
        {
            var cat = LetsworkDbcontext.Categorie.Find(IdCategorie);

            if (cat != null)
            {
                LetsworkDbcontext.Entry(categorie).State = EntityState.Modified;
                return "Bien Modifier";
            }
            else
            {
                return "Existe Pas";

            }

            return "";

        }



    }
}
