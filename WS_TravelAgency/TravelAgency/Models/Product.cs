using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    public partial class Product
    {
        
        public int ID { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public int Category { get; set; }

        public decimal Price { get; set; }

        
        public int IDPack { get; set; }

        //[ForeignKey("FK_Concepto_Producto")]
        public Package IDPackage { get; set; }

    }
}
