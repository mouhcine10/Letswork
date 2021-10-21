using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APILETSWORK.Models
{
    public class Transaction
    {
        [Key]

        public string IdTransaction { get; set; }

        public ApplicationUsers ApplicationUsers { get; set; }

        public string IdPro { get; set; }



    }

}
