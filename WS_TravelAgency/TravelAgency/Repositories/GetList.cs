using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Models;

namespace TravelAgency.Repositories
{
    public class GetList
    {
        public IEnumerable<Product> Prodlist()
        {

            IEnumerable<Product> Products;

            using (AppDBContexts db = new AppDBContexts())
            {

                Products = db.Product.ToList();
            
            }

            return Products;

        }

        public IEnumerable<Package> PacksList(string name)
        {

            IEnumerable<Package> Packages = null;

            using (AppDBContexts db = new AppDBContexts())
            {

                //Packages = db.Packages.Include(P).ToList();

            }

            return Packages;

        }
         
    }
}
