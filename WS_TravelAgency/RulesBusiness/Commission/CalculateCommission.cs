using DataAccess.Models.DTO;
using DataAccess.Repository;
using RulesBusiness.Commission.TypeOfClient;
using System;
using System.Threading.Tasks;

namespace TravelAgency.RulesBusiness
{
    public class CalculateCommission
    {
        public async Task<CommissionResult> Commission(CommissionRequest Com)
        {
            //CommissionIndividual ComInd = new CommissionIndividual();
            //CommissionCorporate ComCor = new CommissionCorporate();
          
            GetFromDB ListaPacks = new GetFromDB();

            var Products = await ListaPacks.Productlist(Com.Packages);

            decimal commission = 0;

            if (Com.ClientId == 1)
            {
                foreach (var item in Products)
                {
                    switch (item.Type)
                    {
                        case "Hotel":
                            { commission = commission + CommissionIndividual.Hotel(item.Price, Com.Duration); };
                            break;

                        case "RentCar":
                            { commission = commission + CommissionIndividual.RentCar(item.Price, Convert.ToInt32(item.Category)); };
                            break;

                        case "Ticket":
                            { commission = commission + CommissionIndividual.Ticket(item.Price); };
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
                            { commission = commission + CommissionCorporate.Hotel(item.Price, Com.Duration); };
                            break;

                        case "RentCar":
                            { commission = commission + CommissionCorporate.RentCar(item.Price, Com.Duration);};
                            break;

                        case "Ticket":
                            { commission = commission + CommissionCorporate.Ticket(item.Price);};
                            break;

                        default:
                            break;
                    }
                }

                commission = (commission * Com.Passengers)/10;
            }

            CommissionResult cr = new CommissionResult();

            cr.Message = "Your commission is $" + commission.ToString();

            return cr;
        }
    }
}
