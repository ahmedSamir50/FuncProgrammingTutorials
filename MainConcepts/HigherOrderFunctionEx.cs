using System;
using System.Collections.Generic;
using System.Text;

namespace FuncProgrammingTutorials.MainConcepts
{
    /// <summary>
    ///  Higher Order function is 
    ///  a function takes a function as an argument 
    ///  or return function
    ///  or both 
    /// </summary>
    public class HigherOrderFunctionEx
    {
        public static void ListOfFuncOrDelegates()
        {
            Func<double, double> delegateTodivByTwo = DivideByTwo;
            Func<double, double> delegateTodivByFourAndAdd4 = DivideByFourAndAddOne;
            List<Func<double, double>> compine = new List<Func<double, double>> {
            delegateTodivByTwo , delegateTodivByFourAndAdd4
        };

        }
        public static double DivideByTwo(double x) => x / 2;
        public static double DivideByFourAndAddOne(double x) => (x / 4) + 1;

        public static double HigherOrderFunc1(Func<double, double> func, double val)
                                              => func(val) + val;
    }
}
