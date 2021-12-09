using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalGains.Domain.Entities
{
    public class OperationEntity
    {
        public string Operation { get; set; }

        public decimal UnitCost { get; set; }

        public int Quantity { get; set; }

        public decimal Tax { get; set; }

        public OperationEntity(string operation, decimal unitCost, int quantity)
        {
            this.Operation = operation;
            this.UnitCost = unitCost;
            this.Quantity = quantity;
        }
    }
}
