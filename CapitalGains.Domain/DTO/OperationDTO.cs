using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalGains.Domain.DTO
{
    public class OperationDTO
    {
        [JsonProperty("operation")]
        public string Operation { get; set; }

        [JsonProperty(PropertyName = "unit-cost")]
        public decimal UnitCost { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
