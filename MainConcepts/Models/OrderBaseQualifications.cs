using FuncProgrammingTutorials.MainConcepts.IFaces;
using System;

namespace FuncProgrammingTutorials.MainConcepts.Models
{
    public class OrderBaseQualifications : IOrderBaseQualifications
    {
        public int ProductIndex{ get; set; }
        public Product OrdProduct { get; set; }
        public decimal A(Order o) => 55.6m;
        public decimal B(Order o) => 355.6m;
        public decimal C(Order o) => 355.6m;
        public bool IsA_Qualified(Order o) => (new Random().Next(0, 10) % 2) == 0;
        public bool IsB_Qualified(Order o) => (new Random().Next(0, 10) % 5) == 0;
        public bool IsC_Qualified(Order o) => (new Random().Next(0, 10) % 3) == 0;
    }
}