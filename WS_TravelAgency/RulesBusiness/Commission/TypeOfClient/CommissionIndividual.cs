﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RulesBusiness.Commission.TypeOfClient
{
    public class CommissionIndividual
    {

        public decimal Hotel(decimal price, int duration)
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

        public decimal RentCar(decimal price, int category)
        {

            decimal com = (price / 100) + (100 * category);

            return com;
        }

        public decimal Ticket(decimal price)
        {

            decimal com = price / 10;

            return com;
        }
    }
}
