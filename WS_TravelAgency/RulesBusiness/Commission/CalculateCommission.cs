using DataAccess.Models.Request;
using DataAccess.Repository;
using RulesBusiness.Commission.TypeOfClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.RulesBusiness
{
    public class CalculateCommission
    {
        public decimal Commission(CommissionRequest Com)
        {
            CommissionIndividual ComInd = new CommissionIndividual();
            CommissionCorporate ComCor = new CommissionCorporate();
          
            GetList ListaPacks = new GetList();

            var Products = ListaPacks.CommissionProductlist(Com.Packages);

            decimal commission = 0;

            if (Com.ClientId == 1)
            {
                foreach (var item in Products)
                {
                    switch (item.Type)
                    {
                        case "Hotel":
                            { commission = commission + ComInd.Hotel(item.Price, Com.Duration); };
                            break;

                        case "RentCar":
                            { commission = commission + ComInd.RentCar(item.Price, item.Category); };
                            break;

                        case "Ticket":
                            { commission = commission + ComInd.Ticket(item.Price); };
                            break;

                        default:
                            break;
                    }
                }
                commission = commission * Com.Passengers;
            }
            else if (Com.ClientId == 2)
            {
                foreach (var item in Products)
                {
                    switch (item.Type)
                    {
                        case "Hotel":
                            { commission = commission + ComCor.Hotel(item.Price, Com.Duration); };
                            break;

                        case "RentCar":
                            { commission = commission + ComCor.RentCar(item.Price, Com.Duration);};
                            break;

                        case "Ticket":
                            { commission = commission + ComCor.Ticket(item.Price);};
                            break;

                        default:
                            break;
                    }
                }

                commission = (commission * Com.Passengers)/10;
            }

            return commission;
        }
    }
}
