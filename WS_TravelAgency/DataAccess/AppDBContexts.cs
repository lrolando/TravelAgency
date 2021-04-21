using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DataAccess
{
    public partial class AppDBContexts : DbContext, IAppDBContexts
    {
        public AppDBContexts() { }

        public AppDBContexts(DbContextOptions<AppDBContexts> options) : base(options) 
        {
        
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<ClientType> ClientTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=DESKTOP-2NNNOP4\\SQLEXPRESS; Initial Catalog=TravelAgencyDB; Integrated Security=True;");
            
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductID);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .IsRequired(false)
                    .HasMaxLength(1)
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
                entity.HasKey(e => e.PackageID);
                
                entity.Property(e => e.Namepack)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

            });

            modelBuilder.Entity<ClientType>(entity =>
            {
                entity.HasKey(e => e.ClientTypeId);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

            });

            modelBuilder.Entity<ClientType>().HasData(

               new ClientType
               {
                   ClientTypeId = 1,
                   Description = "Individual"
               },
               new ClientType
               {
                   ClientTypeId = 2,
                   Description = "Corporate"
               });


            modelBuilder.Entity<Package>().HasData(

                new Package
                {
                    PackageID = 1,
                    Namepack = "Cordoba"
                },
                new Package
                {
                    PackageID = 2,
                    Namepack = "San Juan"
                });


           modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    ProductID = 1,
                    Description = "Hotel Sol",
                    Type = "Hotel",
                    Category = null,
                    Price = 350,
                    IDPack = 1
                },
                new Product
                {
                    ProductID = 2,
                    Description = "VW Vento",
                    Type = "RentCar",
                    Category = "2",
                    Price = 120,
                    IDPack = 1
                },
                new Product
                {
                    ProductID = 3,
                    Description = "B747",
                    Type = "Ticket",
                    Category = null,
                    Price = 380,
                    IDPack = 1
                },
                new Product
                {
                    ProductID = 4,
                    Description = "A380",
                    Type = "Ticket",
                    Category = null,
                    Price = 120,
                    IDPack = 2
                },
                new Product
                {
                    ProductID = 5,
                    Description = "Renault",
                    Type = "RentCar",
                    Category = "3",
                    Price = 220,
                    IDPack = 2
                });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

       
    }
}
