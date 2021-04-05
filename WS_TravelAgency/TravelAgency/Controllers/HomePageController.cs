using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Models.Response;
using TravelAgency.Repository;

namespace TravelAgency.Controllers
{
    
    [ApiController]
    [Route("[Controller]")]
    public class HomePageController : ControllerBase
    {
        
        
        [HttpGet]
        public IActionResult Get()
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
        public IActionResult Post(Package name)
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

        
        //[HttpGet]
        //public IActionResult Get(IEnumerable<Package> aa)
        //{
        //    Response oResponse = new Response();

        //    try
        //    {
        //        //IEnumerable<Package> Pack

        //        oResponse.Exit = 1;
        //        //oResponse.Data = Pack;

        //    }
        //    catch (Exception ex)
        //    {
        //        oResponse.Message = ex.Message;
        //    }

        //    return Ok(oResponse);
        //}
    }
}
