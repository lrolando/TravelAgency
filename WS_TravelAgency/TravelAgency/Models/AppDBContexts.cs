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

    }
}
