using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        public virtual int IDPack { get; set; }

        public virtual string Description { get; set; }

        public virtual string Type { get; set; }

        public virtual int Category { get; set; }

        public virtual decimal Price { get; set; }
    }
}
