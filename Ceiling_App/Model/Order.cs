using System;
using System.Collections.Generic;
using Newtonsoft.Json;

#nullable disable

namespace Ceiling_App.Model
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public double P { get; set; }
        public double S { get; set; }
        public int Spotlight { get; set; }
        public int Lustra { get; set; }
        public int Pipe { get; set; }
        [JsonProperty("angle")]
        public int Ugl { get; set; }
        public int ClientId { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public virtual Client Client { get; set; }

        public double ClientPrice => P * 150 + S * 300 + Spotlight * 450 + Lustra * 200 + Pipe * 100 + (Ugl - 4) * 150;
        public double MaterialCost => P * 30 + S * 120 + Spotlight * 200 + Lustra * 50 + Pipe * 25 + (Ugl - 4) * 100;
        public double Profit => ClientPrice - MaterialCost;

        public string ToDetails()
        {
            if (ClientPrice <= 0 || MaterialCost <= 0 || Profit <= 0 )
            
            { 
            return OrderName + ":      " + "Периметр помещения составляет " + P + " метров погонных. Площадь " + S + " квадратных метров. Будет установлено " +
                Spotlight + " светильник(ов,а) " + Lustra + " люстр(а), " + Pipe + " труб(а) в помещении " + Ugl + " угл(а, ов).";
            }
            else
            {
                return OrderName + ":      " + "Периметр помещения составляет " + P + " метров погонных. Площадь " + S + " квадратных метров. Будет установлено " +
                Spotlight + " светильник(ов,а) " + Lustra + " люстр(а), " + Pipe + " труб(а) в помещении " + Ugl + " угл(а, ов). Цена для клиента составит " +
                ClientPrice + " рублей. Цена комплектующих для монтажа " + MaterialCost + " рублей. Доход с монтажа " + Profit + " рублей.";
            }
                           
        }

        public override string ToString()
        {
            return OrderName;
        }
    }
}
