using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrAgTestXUnit
{
    public class Samples
    {
        public async Task<IEnumerable<Product>> GetSampleProduct()
        {

            IEnumerable<Product> List;

            Product pr1 = new Product();
            pr1.ProductID = 1;
            pr1.Description = "Hotel sol";
            pr1.Type = "Hotel";
            pr1.Category = "";
            pr1.Price = 250;
            pr1.IDPack = 1;

            Product pr2 = new Product();
            pr2.ProductID = 1;
            pr2.Description = "Hotel sol";
            pr2.Type = "Hotel";
            pr2.Category = "";
            pr2.Price = 250;
            pr2.IDPack = 1;

            List<Product> Prelist = new List<Product>
            { pr1, pr2 };

            List = (from a in Prelist select a).ToList();


            return List;
        }



    }


}

