using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APILETSWORK.Models
{
    public class Commentaire
    {
        [Key]
        public string IdCommentaire { get; set; }

        public string Titre { get; set; }

        public string Contenu { get; set; }

        public DateTime DateCommentaire { get; set; }

        public ApplicationUsers ApplicationUsers { get; set; }
        public string Idclient { get; set; }
    }
}
