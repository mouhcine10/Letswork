using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APILETSWORK.Models
{
    public class Categorie
    {
        [Key]
        public string IdCategorie { get; set; }

        public string NomCategorie { get; set; }

        public string Logo { get; set; }

    }
}
