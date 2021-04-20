using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulesBusiness.Commission.TypeOfClient
{
    public static class CommissionIndividual
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
                        { commission = commission + RentCar(item.Price, Convert.ToInt32(item.Category)); };
                        break;

                    case "Ticket":
                        { commission = commission + Ticket(item.Price); };
                        break;

                    default:
                        break;
                }
            }

            commission = commission * passengers;

            return commission;
        }

        public static decimal Hotel(decimal price, int duration)
        {
            decimal com = 0;

            if (duration <6 )
            {
                com = price / 2;                
            }
            else if(duration >= 6)
            {
                com = (duration / 6) * price;
            }
            return com;
        }

        public static decimal RentCar(decimal price, int category)
        {

            decimal com = (price / 100) + (100 * category);

            return com;
        }

        public static decimal Ticket(decimal price)
        {

            decimal com = price / 10;

            return com;
        }
    }
}
