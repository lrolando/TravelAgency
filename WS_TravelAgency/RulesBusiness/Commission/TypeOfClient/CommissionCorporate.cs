using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulesBusiness.Commission.TypeOfClient
{
    public class CommissionCorporate
    {
        public decimal Hotel(decimal price, int duration)
        {

            decimal com = price * duration;

            return com;
        }

        public decimal RentCar(decimal price, int duration)
        {

            decimal com = price * duration;

            return com;
        }

        public decimal Ticket(decimal price)
        {

            decimal com = price * 2;

            return com;
        }
        //public decimal Calculate(int pas, int nig, IEnumerable<Product> prod)
        //{

        //    //decimal commission = 0;

        //    //foreach (var item in prod)
        //    //{
        //    //    switch (item.Type)
        //    //    {
        //    //        case "Hotel":
        //    //            commission = commission + nig * item.Price;
        //    //            break;

        //    //        case "RentCar":
        //    //            commission = commission + item.Price / 100 + 100 * item.Category;
        //    //            break;

        //    //        case "Ticket":
        //    //            commission = commission + item.Price / 10;

        //    //            break;

        //    //        default:
        //    //            break;
        //    //    }

        //    //}

        //    //decimal commissiontotal = commission * pas;

        //    return commissiontotal;

        //}

    }
}
