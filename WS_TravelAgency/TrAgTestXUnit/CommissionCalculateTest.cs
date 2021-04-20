using DataAccess.Models;
using RulesBusiness.Commission.TypeOfClient;
using System;
using System.Collections.Generic;
using Xunit;

namespace TrAgTestXUnit
{
    public class CommissionCalculateTest
    {
        [Fact]
        public void CommissionCalculateClient1()
        {

            var expectedd = 1242.6;
            var expected = Convert.ToDecimal(expectedd);


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

            List<Product> ListPro = new List<Product>() { pr1, pr2, pr3};
            
            decimal actual = CommissionIndividual.Main(ListPro, 5, 3);


            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CommissionCalculateClient2()
        {

            var expectedd = 933;
            var expected = Convert.ToDecimal(expectedd);


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

            decimal actual = CommissionCorporate.Main(ListPro, 5, 3);


            Assert.Equal(expected, actual);

        }
    }
}
