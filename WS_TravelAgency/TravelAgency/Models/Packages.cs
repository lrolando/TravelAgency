﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models
{

    public class Packages
    {
        [Key]
        public int id { get; set; }

        public string Namepack { get; set; }

    }

    //public class CompletePackages : Packages
    //{
        
    //    public ICollection<Product> ProductList { get; set; }
    //}
}
