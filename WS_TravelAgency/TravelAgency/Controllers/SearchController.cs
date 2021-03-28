using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Models.Response;

namespace TravelAgency.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {

        //private readonly AppDBContexts contexts;

        //public SearchController(AppDBContexts contexts)
        //{
        //    this.contexts = contexts;
        //}

        [HttpGet]
        public IActionResult Get()
        {
            Response oRespuesta = new Response();
            try
            {
                using (AppDBContexts db = new AppDBContexts())
                {
                    //var lst = db.ListPackages.Add(from a in db.ListProduct
                    //                              join s in db.ListPackage
                    //                               on a.id equals s.id
                    //                              select new CompletePackages
                    //                              {
                                                      
                    //                              };
                    oRespuesta.Exit = 1;
                    //oRespuesta.Data = lst;
         
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Message = ex.Message;
            }

            return Ok(oRespuesta);
        }
    }
}
