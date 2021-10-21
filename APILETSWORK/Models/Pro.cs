using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APILETSWORK.Models
{
    public class Pro
    {
        [Key]
        public string IdPro { get; set; }

        public string IdClient { get; set; }

        public string Code { get; set; }

        public byte[] cinRecto { get; set; }

        public byte[] cinverso { get; set; }

        public byte[] kabis { get; set; }

        public ApplicationUsers ApplicationUsers { get; set; }


    }
}
