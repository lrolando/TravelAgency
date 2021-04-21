using DataAccess;
using DataAccess.Models;
using DataAccess.Models.DTO;
using DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using RulesBusiness.Commission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace TrAgTestXUnit
{
    public class CommissionTest
    {

        //private readonly Task<IEnumerable<Product>> List = { };
        private Commission comm;
        private Mock<IDBRepository> dbRepositorymock;
        private Task<IEnumerable<Product>> List;

        
        public void Setup()
        {

            dbRepositorymock = new Mock<IDBRepository>();


            //Task<IEnumerable<Product>> List = ;

            Samples smpl = new Samples();

            //List = await (from a in Prelist select a).ToList();

            //List = (Task<IEnumerable<Product>>)await GetProducts(smpl.GetSampleProduct());

            dbRepositorymock.Setup(c => c.GetProductlist(It.IsAny<int[]>())).Returns(smpl.GetSampleProduct());

            comm = new Commission(dbRepositorymock.Object);

        }


        [Fact]
        public void Commission()
        {

            var creq = new CommissionRequest();


            int[] rr = { 1, 2 };
            creq.ClientId = 1;
            creq.Duration = 3;
            creq.Passengers = 4;
            creq.Packages = rr;


            var result = comm.GetCommission(creq);


        }








        //public async Task<IEnumerable<Product>> GetProductlist()
        //{
        //    IEnumerable<Product> List = null;

        //    Product pr1 = new Product();
        //    pr1.ProductID = 1;
        //    pr1.Description = "Hotel sol";
        //    pr1.Type = "Hotel";
        //    pr1.Category = "";
        //    pr1.Price = 250;
        //    pr1.IDPack = 1;

        //    Product pr2 = new Product();
        //    pr2.ProductID = 1;
        //    pr2.Description = "Hotel sol";
        //    pr2.Type = "Hotel";
        //    pr2.Category = "";
        //    pr2.Price = 250;
        //    pr2.IDPack = 1;

        //    List<Product> Prelist = new List<Product>
        //    { pr1, pr2 };

        //    List = (from a in Prelist select a);

        //    return List;
        //}




        //private readonly AppDBContexts _appDBContexts;
        //private readonly IDBRepository _dbRepository;

        //public CommissionTest(IDBRepository dbRepository)
        //{
        //    _dbRepository = dbRepository;

        //}


        //[Fact]
        //public void Commission()
        //{

        //    var context = new AppDBContexts(new DbContextOptions<AppDBContexts>());

        //    context.Product.Add(new Product()
        //    {
        //        ProductID = 2,
        //        Description = "A",
        //        Type = "",
        //        Category = "",
        //        Price = 0
        //    });

        //    var mock = new Mock<AppDBContexts>();
        //    mock.Setup(ctx => ctx.Product).Returns(context.Product);

        //    var ss = new DBRepository(mock.Object);

        //    var svc = new Commission(ss);

        //    var CommReq = new CommissionRequest
        //    {
        //        ClientId = 1,
        //        Passengers = 5,
        //        Duration = 3,

        //    };


        //    var beer = svc.GetCommission(CommReq);


        //    Assert.Equal(2, beer.Id);

        //}

    }
}
