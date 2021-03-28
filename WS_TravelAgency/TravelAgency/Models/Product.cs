using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    public class Product
    {
        public int id { get; set; }
        public int idpackages { get; set; }
        public string Description { get; set; }
        public string type { get; set; }
        public int Category { get; set; }
        public decimal Price { get; set; }
    }
}
