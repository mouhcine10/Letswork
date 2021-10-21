using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LestworkApi.Models
{
    public class TransactionPaiement
    {
        [Key]
        public int Id_transaction { get; set; }

        public string IDTransaction { get; set; }
        public string ID_Pro { get; set; }
        public string ID_client { get; set; }
        public ApplicationUser client { get; set; }


    }
}
