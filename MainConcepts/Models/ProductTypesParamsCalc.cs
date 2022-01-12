using FuncProgrammingTutorials.MainConcepts.IFaces;
using System;

namespace FuncProgrammingTutorials.MainConcepts.Models
{
    public static class ProductTypesParamsCalc
    {
        public static Func<int, (double x1, double x2)> CalculationSwitcher(IOrderBaseQualifications order)
        {
            Func<int, (double x1, double x2)> paramFood = ProductTypesParamsCalc.ProductParametersForFood;
            Func<int, (double x1, double x2)> paramBrev = ProductTypesParamsCalc.ProductParametersForBeverages;
            Func<int, (double x1, double x2)> paramRawMat = ProductTypesParamsCalc.ProductParametersForMaterial;
            Enums.ProductTypes prodType = order.OrdProduct.ProdType;
            return prodType == Enums.ProductTypes.FOOD ? paramFood :
                   prodType == Enums.ProductTypes.Beverages ? paramBrev :
                               paramRawMat;
        }
        public static (double x1, double x2) ProductParametersForFood(int produxtIndex)
               => (x1: produxtIndex / (double)(produxtIndex + 100), x2: produxtIndex / (double)(produxtIndex + 300));

        public static (double x1, double x2) ProductParametersForBeverages(int produxtIndex)
           => (x1: produxtIndex / (double)(produxtIndex + 155.5), x2: produxtIndex / (double)(produxtIndex + 500));

        public static (double x1, double x2) ProductParametersForMaterial(int produxtIndex)
           => (x1: produxtIndex / (double)(produxtIndex + 102), x2: produxtIndex / (double)(produxtIndex + (900 / 2.5)));
    }
}