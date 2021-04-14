using DataAccess.Models;
using DataAccess.Models.DTO;
using DataAccess.Models.Response;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


namespace TravelAgency.Controllers
{
    
    [ApiController]
    [Route("[controller]/[Action]")]
    public class DetailsController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Details([FromBody] Package pack)
        {
            Response oRespuesta = new Response();
            Package lst = null;
            try
            {
                GetFromDB ListaPacks = new GetFromDB();
                lst = await ListaPacks.DetailsPackage(pack);

                oRespuesta.Exit = 1;
                oRespuesta.Data = lst;

            }
            catch (Exception ex)
            {
                oRespuesta.Message = ex.Message;
            }

            return Ok(lst);
        }


    }
}
