using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    public class PackagesName
    {
        [Key]
        public int id { get; set; }

        public string Namepack { get; set; }
    }
}
