using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Jagged_array
{
 
    public static class JaggedSort
    {

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }

        public static void Sort(this int[][] array,IJagedComparer<int> comparator)
        {
            if (array != null)
            {            
                for (int i = 0; i < array.Length  - 1; i++)
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if(comparator.Compare(array[j],array[j+1]) > 0)
                            Swap(ref array[j], ref array[j + 1]);
                    }
            }
        }

        }
}
