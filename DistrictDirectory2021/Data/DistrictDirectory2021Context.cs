using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DistrictDirectory2021.Models;

namespace DistrictDirectory2021.Models
{
    public class DistrictDirectory2021Context : DbContext
    {
        public DistrictDirectory2021Context (DbContextOptions<DistrictDirectory2021Context> options)
            : base(options)
        {
        }

        public DbSet<DistrictDirectory2021.Models.Member> Member { get; set; }
        public DbSet<DistrictDirectory2021.Models.Bank> Bank { get; set; }
     
    }
}
