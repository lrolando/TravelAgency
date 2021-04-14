using DataAccess.Models;
using DataAccess.Models.DTO;
using DataAccess.Models.Response;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TravelAgency.RulesBusiness;

namespace TravelAgency.Controllers
{
    
    [ApiController]
    [Route("[Controller]/[Action]")]
    public class HomePageController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> ClientTypes()
        {
            Response oResponse = new Response();
            IEnumerable<ClientType> lst = null;
            try
            {
                GetFromDB ListaPacks = new GetFromDB();
                lst = await ListaPacks.ClientTypes();

                oResponse.Exit = 1;
                oResponse.Data = lst;

            }
            catch (Exception ex)
            {
                oResponse.Message = ex.Message;
            }

            return Ok(lst);
        }


        [HttpPost]
        public async Task<IActionResult> PackagesByDescription([FromBody] Package package)
        {
            Response oResponse = new Response();
            IEnumerable<Package> lst = null;

            try
            {
                GetFromDB ListaPacks = new GetFromDB();
                lst = await ListaPacks.Packageslist(package.Namepack);

                oResponse.Exit = 1;
                oResponse.Data = lst;

            }
            catch (Exception ex)
            {
                oResponse.Message = ex.Message;
            }

            return Ok(lst);
        }


        [HttpPost]
        public async Task<IActionResult> Commission([FromBody] CommissionRequest Com)
        {
            Response oResponse = new Response();
            CommissionResult commission = null;
            try
            {
                CalculateCommission Comm = new CalculateCommission();

                commission = await Comm.Commission(Com);
                
                oResponse.Exit = 1;
                oResponse.Data = commission;
            }
            catch (Exception ex)
            {
                oResponse.Message = ex.Message;
            }

            return Ok(commission);
        }
    }
}