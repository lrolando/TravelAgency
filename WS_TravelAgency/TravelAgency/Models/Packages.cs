using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models
{

    public class Packages 
    {
        public int id { get; set; }
        public string Name { get; set; }
        
    }

    public class CompletePackages : Packages
    {
        public ICollection<Product> ProductList { get; set; }
    }
}
