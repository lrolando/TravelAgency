using DataAccess.Models;
using DataAccess.Models.Request;
using DataAccess.Models.Response;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.RulesBusiness;

namespace TravelAgency.Controllers
{
    
    [ApiController]
    [Route("[Controller]/[Action]")]
    public class HomePageController : ControllerBase
    {
        
        
        [HttpGet]
        public IActionResult GetTypeClient()
        {
            Response oResponse = new Response();

            try
            {
                GetList ListaPacks = new GetList();
                IEnumerable<Client> lst = ListaPacks.Types().ToList();

                oResponse.Exit = 1;
                oResponse.Data = lst;

            }
            catch (Exception ex)
            {
                oResponse.Message = ex.Message;
            }

            return Ok(oResponse);
        }


        [HttpPost]
        public IActionResult Post(PackageRequest name)
        {
            Response oResponse = new Response();

            try
            {
                GetList ListaPacks = new GetList();
                IEnumerable<Package> lst = ListaPacks.Packageslist(name.Namepack).ToList();

                oResponse.Exit = 1;
                oResponse.Data = lst;

            }
            catch (Exception ex)
            {
                oResponse.Message = ex.Message;
            }

            return Ok(oResponse);
        }


        [HttpGet]
        public IActionResult GetCommission(CommissionRequest Com)
        {
            Response oResponse = new Response();

            try
            {

                CalculateCommission Comm = new CalculateCommission();

                decimal commission = Comm.Commission(Com);
                

                oResponse.Exit = 1;
                oResponse.Data = commission;
            }
            catch (Exception ex)
            {
                oResponse.Message = ex.Message;
            }

            return Ok(oResponse);
        }
    }
}