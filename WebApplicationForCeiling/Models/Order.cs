using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApplicationForCeiling.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int ClientId { get; set; }

        [JsonIgnore]
        public Client Client { get; set; }

        public DateTime CreatedAt { get; set; }

        public string OrderName { get; set; }

        public double P { get; set; }

        public double S { get; set; }

        public int Spot { get; set; }

        public int Lustra { get; set; }

        public int Pipe { get; set; }

        public int Angle { get; set; }

        public double Price1;
        public double Price2;
        public double price3;
    }
}
