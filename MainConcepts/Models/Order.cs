using FuncProgrammingTutorials.MainConcepts.IFaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FuncProgrammingTutorials.MainConcepts.Models
{
    public class Order : OrderBaseQualifications , IDiscountableOrder
    {
        public int OrderID { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }

        public double CalculatDescount(Func<int, (double, double)> ProductCalc)
        {
            return Order_1Descount.CalculatDescount(this, ProductCalc);
          
        }
    }
    public static class Order_1Descount {
        public static double CalculatDescount(this IOrderBaseQualifications order,Func<int, (double, double)> ProductCalc)
        {
            (double x1, double x2) = ProductCalc(order.ProductIndex);
            Order O = order as Order;
            return x1 * O.Quantity * x2 * O.UnitPrice;
        }
    }
}