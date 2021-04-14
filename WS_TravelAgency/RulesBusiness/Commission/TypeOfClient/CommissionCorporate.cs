using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulesBusiness.Commission.TypeOfClient
{
    public static class CommissionCorporate
    {
        public static decimal Hotel(decimal price, int duration)
        {

            decimal com = price * duration;

            return com;
        }

        public static decimal RentCar(decimal price, int duration)
        {

            decimal com = price * duration;

            return com;
        }

        public static decimal Ticket(decimal price)
        {

            decimal com = price * 2;

            return com;
        }
        
    }
}
