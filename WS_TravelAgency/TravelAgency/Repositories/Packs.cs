using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Models;

namespace TravelAgency.Repositories
{
    public class Packs
    {

        public IEnumerable<Product> PacksList()
        {

            IEnumerable<Product> PL;

            using(AppDBContexts db = new AppDBContexts())
            {
            
                PL = db.ListProduct.ToList();

            }

            return PL;

        }


    }
}
