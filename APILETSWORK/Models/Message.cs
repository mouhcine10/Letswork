using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APILETSWORK.Models
{
    public class Message
    {
        [Key]
        public string IdMessage { get; set; }
        public string Centenu { get; set; }

        public String Etat { get; set; }

        public string DateMessage { get; set; }

        public string IDUser { get; set; }

        public ApplicationUsers ApplicationUsers { get; set; }

    }
}
