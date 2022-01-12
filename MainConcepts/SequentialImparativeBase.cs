using System;

namespace FuncProgrammingTutorials.MainConcepts
{
    public class SequentialMethods
    {
        // pure function add one 
        public static double AddOne(double toAddOneTo) => ++toAddOneTo;
        // pure function
        public static double Square(double toSquare) => Math.Pow(toSquare,2);
        // pure function 
        public static double SubstractTen(double toSub) => toSub - 10;
    }
}