﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILETSWORK.Models
{
    public class Register
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string Email { get; set; }
        public string Telephone { get; set; }

        public string Adresse { get; set; }

        public string CodePostal { get; set; }

        public string Ville { get; set; }

        public string Pays { get; set; }

        public string Password { get; set; }
    }
}
