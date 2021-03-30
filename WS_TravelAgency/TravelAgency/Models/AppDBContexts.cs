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


        public DbSet<Product> ListProduct { get; set; }
        public DbSet<Packages> ListPackage { get; set; }

        public DbSet<CompletePackages> ListPackages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=DESKTOP-2NNNOP4\\SQLEXPRESS; Initial Catalog=DBTravelAgency; Integrated Security=True;");
            }
        }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>(entity =>
        //    {
               

        //    });

        //    modelBuilder.Entity<Packages>(entity =>
        //    {
                
        //    });

        //    modelBuilder.Entity<CompletePackages>(entity =>
        //    {
                
        //    });


        //    //OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    

    }
}
