using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    public class AppDBContexts : DbContext
    {
        public AppDBContexts() { }

        public AppDBContexts(DbContextOptions<AppDBContexts> options) : base(options) 
        {
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=DESKTOP-2NNNOP4\\SQLEXPRESS; Initial Catalog=DBTravelAgency; Integrated Security=True;");
            
            }
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Packages> Packages { get; set; }

        //public DbSet<CompletePackages> ListPackages { get; set; }


    }
}
