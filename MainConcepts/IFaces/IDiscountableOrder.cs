using System;

namespace FuncProgrammingTutorials.MainConcepts.IFaces
{
    public interface IDiscountableOrder {
        double CalculatDescount(Func<int, (double, double)> F);
    }
    
}
