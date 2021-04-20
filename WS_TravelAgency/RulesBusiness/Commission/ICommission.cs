using DataAccess.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RulesBusiness.Commission
{
    public interface ICommission
    {

        public Task<decimal> GetCommission(CommissionRequest Com);
    }
}
