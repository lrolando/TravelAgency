using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Models.Response;
using TravelAgency.Repositories;

namespace TravelAgency.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            Response oRespuesta = new Response();
            IEnumerable<Product>  lst = null;
            try
            {
                

                    Packs pk = new Packs();
                    lst = pk.PacksList();
                    

                    oRespuesta.Exit = 1;
                    oRespuesta.Data = lst;
         
                
            }
            catch (Exception ex)
            {
                oRespuesta.Message = ex.Message;
            }
            

            return Ok(oRespuesta);
        }
    }
}
