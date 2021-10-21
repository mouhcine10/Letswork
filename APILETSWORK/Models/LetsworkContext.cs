using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILETSWORK.Models
{
    public class LetsworkContext : IdentityDbContext<ApplicationUsers>
    {


        public LetsworkContext(DbContextOptions<LetsworkContext> options) : base(options)
        {


        }


        public DbSet<Categorie> categories { get; set; }
        public DbSet<Commentaire> commentaires { get; set; }

        public DbSet<Message> messages { get; set; }

        public DbSet<Pro> pros { get; set; }

        public DbSet<Metier> metiers { get; set; }

        public DbSet<Mission> missions { get; set; }
    }
}
