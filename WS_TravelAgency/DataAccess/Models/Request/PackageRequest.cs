using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Models.Request
{
    public class PackageRequest
    {
        public int PackageID { get; set; }
        public string Namepack { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
