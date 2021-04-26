using DataAccess.Models;
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

        private readonly IDBRepository _repositoryDB;

        public DetailsController(IDBRepository repositoryDB)
        {

            _repositoryDB = repositoryDB;

        }

        [HttpPost]
        public async Task<IActionResult> Details([FromBody] Package pack)
        {
            
            Package lst = await _repositoryDB.GetDetailsPackage(pack);

            
            return Ok(lst);
        }

    }
}

