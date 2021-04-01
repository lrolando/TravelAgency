using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    public partial class AppDBContexts : DbContext
    {
        public AppDBContexts() { }

        public AppDBContexts(DbContextOptions<AppDBContexts> options) : base(options) 
        {
        
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Package> Packages { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=DESKTOP-2NNNOP4\\SQLEXPRESS; Initial Catalog=DBTravelAgency; Integrated Security=True;");
            
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IDPackage)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.IDPack)
                    .HasConstraintName("FK_Product_Package");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.HasKey(e => e.IDPack);
                
                entity.Property(e => e.Namepack)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Packages>().HasDiscriminator(b => b.packtype);

        //    modelBuilder.Entity<Packages>()
        //        .HasDiscriminator<string>("Packagetype")
        //        .HasValue<Packages>("Packbase")
        //        .HasValue<PackagesName>("Pack_n");

        //}

    }
}
