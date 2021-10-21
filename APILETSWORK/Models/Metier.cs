using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APILETSWORK.Models
{
    public class Metier
    {
        [Key]
        public string IdMetier { get; set; }

        public string NomMetier { get; set; }

        public string IdPro { get; set; }

        public Pro Pro { get; set; }

    }

}
