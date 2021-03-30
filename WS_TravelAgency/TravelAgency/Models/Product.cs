using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int IDPack { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Category { get; set; }
        public decimal Price { get; set; }
    }
}
