using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsV4._0.Entities
{
    public class MyDBContext :DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Contract> Contracts { get; set; }
    }
}
