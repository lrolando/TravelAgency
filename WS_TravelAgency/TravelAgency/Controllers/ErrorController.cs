using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {

        [Route("/error-local-development")]
        public IActionResult ErrorLocalDevelopment([FromServices] IWebHostEnvironment webHostEnvironment)
        {
            if (webHostEnvironment.EnvironmentName != "Development")
            {
                throw new InvalidOperationException("This shouldn't be invoked in non-development environments.");
            }

            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

            return Problem(detail: context.Error.StackTrace,
                           title: context.Error.Message);
        }

        [Route("/error")]
        public IActionResult Error()
        {

            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

            return Problem(title: context.Error.Message);

        }
    }
}
