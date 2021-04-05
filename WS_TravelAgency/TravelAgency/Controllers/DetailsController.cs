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
    [Route("[controller]")]
    public class DetailsController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get(Package id)
        {
            Response oRespuesta = new Response();

            try
            {
                GetList ListaPacks = new GetList();
                Package lst = ListaPacks.DetailsPackage(id);

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
