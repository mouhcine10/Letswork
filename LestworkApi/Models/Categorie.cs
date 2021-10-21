using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LestworkApi.Models
{
    public class Categorie
    {
        [Key]
        public string Id_Categorie { get; set; }
        

        public string Nomcategorie { get; set; }

        public string PhotoCatégorie { get; set; }

        public string Trakingimage { get; set; }

        public IEnumerable<Metier> Metiers { get; set; }

    }
}
