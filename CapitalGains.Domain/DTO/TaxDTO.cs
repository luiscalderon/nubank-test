using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalGains.Domain.DTO
{
    public class TaxDTO
    {
        public decimal Tax { get; set; }

        public TaxDTO(decimal tax)
        {
            Tax = tax;
        }
    }
}
