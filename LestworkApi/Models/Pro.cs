using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LestworkApi.Models
{
   
    public class Pro
    {
        [Key]
        public string Id_Pro { get; set; }
        public string Imatriculation { get; set; }

        public string TypeActiviter { get; set; }

        public int Ponit { get; set; }
        public string IdClient { get; set; }

        public ApplicationUser Client { get; set; }

        public IEnumerable<TransactionPaiement> transactionPaiements { get; set; }




    }
}
