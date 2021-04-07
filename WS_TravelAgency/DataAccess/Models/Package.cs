using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public partial class Package
    {

        public int PackageID { get; set; }
        public string Namepack { get; set; }

        public ICollection<Product> Product { get; set; }
        
    }
}
