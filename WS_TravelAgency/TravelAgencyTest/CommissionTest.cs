using DataAccess.Models;
using DataAccess.Models.DTO;
using DataAccess.Repository;
using Moq;
using NUnit.Framework;
using RulesBusiness.Commission;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyTest
{
    public class CommissionTest
    {

        private Commission comm;
        private Mock<IDBRepository> dbRepositorymock;
        private Samples sam;

        public CommissionTest()
        {

            sam = new Samples();

        }

        [SetUp]
        public void Setup()
        {

            dbRepositorymock = new Mock<IDBRepository>();

            var samplprod = sam.GetSampleProduct();

            dbRepositorymock.Setup(c => c.GetProductlist(It.IsAny<int[]>())).Returns(samplprod);

            comm = new Commission(dbRepositorymock.Object);

        }

        [Test]
        public void Full_commission_calculation_test()
        {

            //Arrange
            var creq = new CommissionRequest();

            creq.ClientId = 1;
            creq.Duration = 5;
            creq.Passengers = 3;
            creq.Packages = new int[] {1, 2};

            decimal expected = 2185.2M;

            //Act
            var result = comm.GetCommission(creq);

            //Assert
            Assert.AreEqual(expected, result.Result);
        }
    }
}
