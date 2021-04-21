using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyTest
{
    class Samples
    {
        public async Task<IEnumerable<Product>> GetSampleProduct()
        {

            IEnumerable<Product> List;

            Product pr1 = new Product();
            pr1.ProductID = 1;
            pr1.Description = "Hotel sol";
            pr1.Type = "Hotel";
            pr1.Category = "";
            pr1.Price = 350;
            pr1.IDPack = 1;

            Product pr2 = new Product();
            pr2.ProductID = 2;
            pr2.Description = "vw";
            pr2.Type = "RentCar";
            pr2.Category = "2";
            pr2.Price = 120;
            pr2.IDPack = 1;

            Product pr3 = new Product();
            pr3.ProductID = 3;
            pr3.Description = "B747";
            pr3.Type = "Ticket";
            pr3.Category = "";
            pr3.Price = 380;
            pr3.IDPack = 1;

            Product pr4 = new Product();
            pr4.ProductID = 4;
            pr4.Description = "A380";
            pr4.Type = "Ticket";
            pr4.Category = "";
            pr4.Price = 120;
            pr4.IDPack = 2;

            Product pr5 = new Product();
            pr5.ProductID = 5;
            pr5.Description = "Renault";
            pr5.Type = "RentCar";
            pr5.Category = "3";
            pr5.Price = 220;
            pr5.IDPack = 2;

            List<Product> Prelist = new List<Product>
            { pr1, pr2, pr3, pr4, pr5 };

            List = (from a in Prelist select a).ToList();


            return Prelist;
        }


        public IEnumerable<Product> GetSampleProductCl1()
        {

            Product pr1 = new Product();
            pr1.ProductID = 1;
            pr1.Description = "Hotel Sol";
            pr1.Type = "Hotel";
            pr1.Category = null;
            pr1.Price = 350;
            pr1.IDPack = 1;

            Product pr2 = new Product();
            pr2.ProductID = 2;
            pr2.Description = "VW Vento";
            pr2.Type = "RentCar";
            pr2.Category = "2";
            pr2.Price = 120;
            pr2.IDPack = 1;

            Product pr3 = new Product();
            pr3.ProductID = 3;
            pr3.Description = "B747";
            pr3.Type = "Ticket";
            pr3.Category = null;
            pr3.Price = 380;
            pr3.IDPack = 1;

            List<Product> ListPro = new List<Product>() { pr1, pr2, pr3 };


            return ListPro;
        }

        public IEnumerable<Product> GetSampleProductCl2()
        {

            Product pr1 = new Product();
            pr1.ProductID = 1;
            pr1.Description = "Hotel Sol";
            pr1.Type = "Hotel";
            pr1.Category = null;
            pr1.Price = 350;
            pr1.IDPack = 1;

            Product pr2 = new Product();
            pr2.ProductID = 2;
            pr2.Description = "VW Vento";
            pr2.Type = "RentCar";
            pr2.Category = "2";
            pr2.Price = 120;
            pr2.IDPack = 1;

            Product pr3 = new Product();
            pr3.ProductID = 3;
            pr3.Description = "B747";
            pr3.Type = "Ticket";
            pr3.Category = null;
            pr3.Price = 380;
            pr3.IDPack = 1;

            List<Product> ListPro = new List<Product>() { pr1, pr2, pr3 };


            return ListPro;
        }

    }
}
