using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Models.DTO
{
    public class CommissionRequest
    {

        public int ClientId { get; set; }
        public int Passengers { get; set; }
        public int Duration { get; set; }
        public int[] Packages { get; set; }
    }
}
