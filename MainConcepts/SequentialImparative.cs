using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuncProgrammingTutorials.MainConcepts
{
    public class SequentialImparative : SequentialMethods
    {
        public static List<double> ImparativeMethod(List<double> listOfData)
        {
            Console.WriteLine("*****ImparativeMethod*****");
            foreach (double item in listOfData)
            {
                Console.WriteLine(SubstractTen(Square(AddOne(item))).ToString());
            }
            return listOfData;
        }
    }
    public class SequentialDeclarative : SequentialMethods
    {
        public static List<double> DeclarativeMethod(List<double> listOfData)
        {
            Console.WriteLine("*****Declarative Method*****");
            listOfData.Select(AddOne)
                      .Select(Square)
                      // adding conditions is much easer in declarative 
                      .Where(x=>x < 20)
                      .Select(SubstractTen)
                      .ToList();
            foreach (double item in listOfData)
            {
                Console.WriteLine(item.ToString());
            }
            return listOfData;
        }
    }

}
