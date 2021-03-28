using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    public class AppDBContexts : DbContext
    {
        public AppDBContexts(DbContextOptions<AppDBContexts> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

    }
}
