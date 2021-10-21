using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LestworkApi.Models
{
    public class Metier
    {
        [Key]
        public string Id_Metier { get; set; }

        public string Id_Categorie { get; set; }
        
        public string NomMetier { get; set; }

        public string IconeMit { get; set; }

      
        public IEnumerable<Pro> Pros { get; set; }



    }
}
