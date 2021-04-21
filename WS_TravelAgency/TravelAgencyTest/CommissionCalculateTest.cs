using DataAccess.Models;
using NUnit.Framework;
using RulesBusiness.Commission.TypeOfClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgencyTest
{
    public class CommissionCalculateTest
    {
        private Samples sam;

        public CommissionCalculateTest()
        {

            sam = new Samples();

        }


        [Test]
        public void Calculate_Commission_Client1()
        {
            //Arrange
            var expected = 1242.6M;

            var ListPro = sam.GetSampleProductCl1();

            //Act
            decimal actual = CommissionIndividual.Main(ListPro, 5, 3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Calculate_Commission_Client2()
        {
            //Arrange
            var expected = 933M;

            var ListPro = sam.GetSampleProductCl2();

            //Act
            decimal actual = CommissionCorporate.Main(ListPro, 5, 3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
