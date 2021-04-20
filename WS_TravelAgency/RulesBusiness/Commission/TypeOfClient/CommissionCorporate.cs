using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulesBusiness.Commission.TypeOfClient
{
    public static class CommissionCorporate
    {

        public static decimal Main(IEnumerable<Product> products, int duration, int passengers)
        {

            decimal commission = 0;

            foreach (var item in products)
            {
                switch (item.Type)
                {
                    case "Hotel":
                        { commission = commission + Hotel(item.Price, duration); };
                        break;

                    case "RentCar":
                        { commission = commission + RentCar(item.Price, duration); };
                        break;

                    case "Ticket":
                        { commission = commission + Ticket(item.Price); };
                        break;

                    default:
                        break;
                }
            }

            commission = (commission * passengers) / 10;

            return commission;
        }

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
