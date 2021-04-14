using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public partial class Product
    {
        
        public int ProductID { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        
        public int IDPack { get; set; }
        public Package IDPackage { get; set; }

    }
}
