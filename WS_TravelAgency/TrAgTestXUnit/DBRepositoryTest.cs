using DataAccess;
using DataAccess.Models;
using DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using Moq;
using RulesBusiness.Commission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace TrAgTestXUnit
{
    public class DBRepositoryTest
    {

        [Fact]
        public void GetClientTypeTestWhitMock()
        {

            var context = new AppDBContexts();

            context.ClientTypes.Add(new ClientType()
            {
                ClientTypeId=1,
                Description ="Individualaa"
            });

            var mock = new Mock<AppDBContexts>();
            mock.Setup(ctx => ctx.ClientTypes).Returns(context.ClientTypes);

            var ss = new DBRepository(mock.Object);

            //var svc = new Commission(ss);

            //var CommReq = new CommissionRequest
            //{
            //    ClientId = 1,
            //    Passengers = 5,
            //    Duration = 3,

            //};


            var beer = ss.GetClientTypes();


            Assert.Equal(1, beer.Id);





        }
    }
}
