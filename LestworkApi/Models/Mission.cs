using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LestworkApi.Models
{
    public class Mission
    {
        [Key]
        public string Id_Mission { get; set; }
        public string Id_Pro { get; set; }
        public string Id_user { get; set; }
        public string Id_Metier { get; set; }

        public DateTime DateMission { get; set; }

        public string DescriptionMission { get; set; }


        public string Cout { get; set; }


        public Metier Metier { get; set; }
        public Pro Pro { get; set; }
        public ApplicationUser client { get; set; }

    }
}
