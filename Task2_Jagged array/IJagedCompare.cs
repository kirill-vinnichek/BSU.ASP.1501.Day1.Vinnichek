using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Jagged_array
{
   public interface IJagedCompare<T> 
    {
       SortingType SortType{get;set;}
       bool Compare(T[] a, T[] b);
    }
}
