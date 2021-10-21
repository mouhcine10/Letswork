using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LestworkApi.Models
{
    public class Message
    {
        [Key]
        public string Id_Message { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public string Id_User { get; set; }

        public string Contenu { get; set; }


        public DateTime DateCreation { get; set; }

        public string EtatMessage { get; set; }


    }
}
