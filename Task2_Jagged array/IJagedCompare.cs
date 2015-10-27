using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Jagged_array
{
   public interface IJagedComparer<T> 
    {
       int Compare(T[] a, T[] b);
    }
}
