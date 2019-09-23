using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DistrictDirectory2021.Models
{
    public class Bank
    {
        [Key]
        public int id { get; set; }
        public string bank_name { get; set; }
    }
}
