﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models.Response
{
    public class Response
    {
        public int Exit { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }

        public Response()
        {
            this.Exit = 0;
        }
    }
}
