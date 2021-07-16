using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsV4._0.Entities
{
    public class Contract
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public double Amount { get; set; }
        public int Govno { get; set; }

        public Contract()
        {
            Id = Guid.NewGuid();
        }
    }
}
