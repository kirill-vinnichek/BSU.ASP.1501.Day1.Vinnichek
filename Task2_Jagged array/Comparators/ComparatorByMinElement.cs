using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Jagged_array.Comparators
{
    public class ComparatorByMinElement : IJagedComparer<int>
    {


        public int Compare(int[] a, int[] b)
        {
            double a_c, b_c;
            if (a == null && b == null)
                return 0;
            if (a == null)
                return 1;
            if (b == null)
                return -1;

            a_c = a.Min();

            b_c = b.Min(); 

            return a_c > b_c ? 1 : a_c < b_c ? -1 : 0;

        }


    }
}
