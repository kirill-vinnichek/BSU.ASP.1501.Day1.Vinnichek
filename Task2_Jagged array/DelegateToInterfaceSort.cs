using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Jagged_array
{
    public static class DelegateToInterfaceSort
    {
        public static void Sort<T>(T[] array, IComparer<T> comparator)
        {
            if (array == null)
                throw new ArgumentNullException("Array is null");
            if (comparator == null)
                if (!typeof(T).GetInterfaces().Contains(typeof(IComparable<T>)))
                    throw new ArgumentNullException("Comparator is null");
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
                        if (comparator.Compare(array[j], array[j + 1]) > 0)
                            Helper.Swap(ref array[j], ref array[j + 1]);
                    }
            }
        }

        public static void Sort<T>(T[] array, Comparison<T> compare)
        {
            if (compare != null)
                Sort(array, Comparer<T>.Create(compare));
            else
                throw new ArgumentNullException("compare is null");
        }

    }
}
