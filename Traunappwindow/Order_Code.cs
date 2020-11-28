using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traunappwindow
{
    public partial class Orders
    {
        /*public int OrderId;
        public string OrderName = "заказ";
        public double P = 1;
        public double S = 1;
        public int spotlight = 0;
        public int Lustra = 0;
        public int Pipe = 0;
        public int ugl = 0;*/
        public double ClientPrice => P * 150 + S * 300 + Spotlight * 450 + Lustra * 200 + Pipe * 100 + (Ugl - 4) * 150;
        public double MaterialCost => P * 30 + S * 120 + Spotlight * 200 + Lustra * 50 + Pipe * 25 + (Ugl - 4) * 100;
        public double Profit => ClientPrice - MaterialCost;

        public override string ToString()
        {
            return OrderName + ":      " + "Периметр помещения составляет " + P + " метров погонных. Площадь " + S + " квадратных метров. Будет установлено " +
                Spotlight + " светильник(ов,а) " + Lustra + " люстр(а), " + Pipe + " труб(а) в помещении " + Ugl + " угл(а, ов). Цена для клиента составит " + 
                ClientPrice + " рублей. Цена комплектующих для монтажа " + MaterialCost + " рублей. Доход с монтажа" + Profit + " рублей.";
        }
    }
}
