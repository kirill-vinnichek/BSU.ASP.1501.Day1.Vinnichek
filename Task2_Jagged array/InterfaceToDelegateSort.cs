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
            if (comparator == null)
                throw new ArgumentNullException("Comparator is null");
            Sort(array, comparator.Compare);
        }

        public static void Sort<T>(T[] array, Comparison<T> compare)
        {
            if (array == null)
                throw new ArgumentNullException("Array is null");
            if (compare == null)
                if (!typeof(T).GetInterfaces().Contains(typeof(IComparable<T>)))
                    throw new ArgumentNullException("compare is null");
                else
                {
                    for (int i = 0; i < array.Length - 1; i++)
                        for (int j = 0; j < array.Length - i - 1; j++)
                        {
                            if (array[j] == null || (array[j] as IComparable<T>).CompareTo(array[j + 1]) > 0)
                                Helper.Swap(ref array[j], ref array[j + 1]);
                        }
                }
            else
            {
                for (int i = 0; i < array.Length - 1; i++)
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (compare(array[j], array[j + 1]) > 0)
                            Helper.Swap(ref array[j], ref array[j + 1]);
                    }
            }
        }
    }
}
