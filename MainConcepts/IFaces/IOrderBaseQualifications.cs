using FuncProgrammingTutorials.MainConcepts.Models;
using System.Collections.Generic;
using System.Text;

namespace FuncProgrammingTutorials.MainConcepts.IFaces
{
    public interface IOrderBaseQualifications
    {
        int ProductIndex { get; set; }
        Product OrdProduct { get; set; }
        bool IsA_Qualified(Order o);
        bool IsB_Qualified(Order o);
        bool IsC_Qualified(Order o);
    }

}
