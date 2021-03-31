using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Models;

namespace TravelAgency.Repositories
{
    public class GetList
    {
        public IEnumerable<Product> prodlist()
        {

            IEnumerable<Product> Products;

            using (AppDBContexts db = new AppDBContexts())
            {

                Products = db.Product.ToList();

            }

            return Products;

        }

        public IEnumerable<Packages> PacksList()
        {

            IEnumerable<Packages> Packages = null;

            using (AppDBContexts db = new AppDBContexts())
            {

                //PL = db.Packages.FromSqlInterpolated($"Select packages.NamePack, product.description, product.type, product.category, product.price from product full outer join packages on product.idpack = packages.id where (packages.NamePack like '%e%')").ToList();

            }

            return Packages;

        }
    }
}
