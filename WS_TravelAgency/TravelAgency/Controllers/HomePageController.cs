using DataAccess.Models;
using DataAccess.Models.DTO;
using DataAccess.Models.Response;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RulesBusiness.Commission;
using RulesBusiness.Commission.TypeOfClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TravelAgency.Controllers
{
    
    [ApiController]
    [Route("[Controller]/[Action]")]
    public class HomePageController : ControllerBase
    {

        private readonly IDBRepository _repositoryDB;
        private readonly ICommission _commission;
        private readonly ICommissionResult _commissionResult;

        public HomePageController(IDBRepository repositoryDB,
                                ICommission commission,
                                ICommissionResult commissionResult)
        {
            _repositoryDB = repositoryDB;
            _commission = commission;
            _commissionResult = commissionResult;
        }

        [HttpGet]
        public async Task<IActionResult> ClientTypes()
        {
            IEnumerable<ClientType> lst = null;
            try
            {
                lst = await _repositoryDB.GetClientTypes();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Ok(lst);
        }


        [HttpPost]
        public async Task<IActionResult> PackagesByDescription([FromBody] Package package)
        {
            
            IEnumerable<Package> lst = null;

            try
            {
                lst = await _repositoryDB.GetPackageslist(package.Namepack);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Ok(lst);
        }


        [HttpPost]
        public async Task<IActionResult> Commission([FromBody] CommissionRequest Com)
        {

            try
            {

                var com = await _commission.GetCommission(Com);

                _commissionResult.Message = "Your commission is $" + com.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return Ok(_commissionResult);
        }
    }
}