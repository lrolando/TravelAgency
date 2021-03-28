using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models.Response
{
    public class Response
    {
        public int Exito { get; set; }

        public string Mensaje { get; set; }

        public object Data { get; set; }

        public Response()
        {
            this.Exito = 0;
        }
    }
}
