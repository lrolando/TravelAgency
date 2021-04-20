using DataAccess.Models.DTO;
using DataAccess.Repository;
using RulesBusiness.Commission.TypeOfClient;
using System;
using System.Threading.Tasks;

namespace RulesBusiness.Commission
{
    public class Commission : ICommission
    {

        private readonly IDBRepository _dbRepository;

        public Commission(IDBRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        public async Task<decimal> GetCommission(CommissionRequest Com)
        {
          
            var Products = await _dbRepository.GetProductlist(Com.Packages);

            decimal commission = 0;

            if (Com.ClientId == 1)
            {

                commission = CommissionIndividual.Main(Products, Com.Duration, Com.Passengers);

            }
            else if (Com.ClientId == 2)
            {

                commission = CommissionCorporate.Main(Products, Com.Duration, Com.Passengers);

            }

            return commission;
        }
    }
}
