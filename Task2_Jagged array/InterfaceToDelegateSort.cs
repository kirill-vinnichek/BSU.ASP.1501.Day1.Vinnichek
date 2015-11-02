using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Jagged_array
{
    public static class InterfaceToDelegateSort
    {
        public static void Sort<T>(T[] array, IComparer<T> comparator)
        {
            Sort(array, comparator.Compare);
        }

        public static void Sort<T>(T[] array, Helper.Compare<T> compare)
        {
            if (array == null)
                throw new ArgumentNullException("Array is null");
            if (compare == null)
                throw new ArgumentNullException("Compare is null");

            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (compare(array[j], array[j + 1]) > 0)
                        Helper.Swap(ref array[j], ref array[j + 1]);
                }
        }
    }
}
