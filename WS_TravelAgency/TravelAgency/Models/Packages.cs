using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models
{

    public class Packages : Product
    {
        public int idPack { get; set; }
        public string Name { get; set; }
        
    }

    public class CompletePackages : Packages
    {
        
        public ICollection<Product> ProductList { get; set; }
    }
}
