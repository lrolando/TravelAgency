using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    public class Packages1
    {
        public int id { get; set; }
        public ICollection<Product> ProductList1 { get; set; }
    }

    public class Packages2 : Packages1
    {
        public ICollection<Product> ProductList2 { get; set; }
    }

    public class Packages3 : Packages2
    {
        public ICollection<Product> ProductList3 { get; set; }
    }
}
