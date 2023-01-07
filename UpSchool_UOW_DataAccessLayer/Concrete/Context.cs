using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool_UOW_EntityLayer.Concreate;

namespace UpSchool_UOW_DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=RAMAZANSURUCU; initial catalog=UpSchoolUow; integrated security=true");
        }
        
        public DbSet<Account> accounts { get; set; }
        public DbSet<ProcessDetail> processDetails { get; set; }

    }
}
