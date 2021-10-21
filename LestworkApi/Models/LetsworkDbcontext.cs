using LestworkApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LestworkApi.DBcontext
{
    public class LetsworkDbcontext : IdentityDbContext<ApplicationUser>
    {

        public LetsworkDbcontext(DbContextOptions<LetsworkDbcontext> options) : base(options)
        {



        }


        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Mission> Mission { get; set; }
        public DbSet<Categorie> Categorie { get; set; }
        public DbSet<TransactionPaiement> TransactionPaiements { get; set; }
        public DbSet<Metier> Metier { get; set; }
        public DbSet<Pro> Prof { get; set; }



    }
}
