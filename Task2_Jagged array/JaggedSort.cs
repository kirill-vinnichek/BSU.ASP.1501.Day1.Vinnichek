using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Jagged_array
{
    public enum SortingType
    {
        IncreasingAmounts, DecreasinAmounts, IncreasingMaxElements, DecreasingMaxElements, IncreasingMinElements, DecreasingMinElements
    }

    public static class JaggedSort
    {

        private static Dictionary<object, double> dictionary = new Dictionary<object, double>();

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }

        private static int CompareBySum(int[] a1,int[] a2)
        {
            double a, b;
            if (!dictionary.TryGetValue(a1,out a))
            {
                a = a1.Sum();
                dictionary.Add(a1, a);
            }
            if (!dictionary.TryGetValue(a2, out b))
            {
                b = a2.Sum();
                dictionary.Add(a2, b);
            }

            return a > b ? 1 : a == b ? 0 : -1;

        }

        private static int CompareByMinElement(int[] a1, int[] a2)
        {
            double a, b;
            if (!dictionary.TryGetValue(a1, out a))
            {
                a = a1.Min();
                dictionary.Add(a1, a);
            }
            if (!dictionary.TryGetValue(a2, out b))
            {
                b = a2.Min();
                dictionary.Add(a2, b);
            }

            return a > b ? 1 : a == b ? 0 : -1;

        }
        private static int CompareByMaxElement(int[] a1, int[] a2)
        {
            double a, b;
            if (!dictionary.TryGetValue(a1, out a))
            {
                a = a1.Max();
                dictionary.Add(a1, a);
            }
            if (!dictionary.TryGetValue(a2, out b))
            {
                b = a2.Max();
                dictionary.Add(a2, b);
            }

            return a > b ? 1 : a == b ? 0 : -1;

        }
        public static void Sort(int[][] array,SortingType type = SortingType.IncreasingAmounts)
        {
            //TODO: подумать над null-ссылками
            //Do not pull out my hands. Just write comments 
            if (array != null)
            {
                if (dictionary != null)
                    dictionary.Clear();
                else
                    dictionary = new Dictionary<object, double>();
               // int numOfNull = 0;
                Func< int[], int[],int> compare;
                int order;
                switch(type)
                {
                    case SortingType.IncreasingAmounts:
                        compare = CompareBySum;
                        order = 1;
                        break;
                    case SortingType.DecreasinAmounts:
                        compare = CompareBySum;
                        order = -1;
                        break;
                    case SortingType.IncreasingMaxElements:
                        compare = CompareByMaxElement;
                        order = 1;
                        break;
                    case SortingType.DecreasingMaxElements:
                        compare = CompareByMaxElement;
                        order = -1;
                        break;
                    case SortingType.IncreasingMinElements:
                        compare = CompareByMinElement;
                        order = 1;
                        break;
                    case SortingType.DecreasingMinElements:
                        compare = CompareByMinElement;
                        order = -1;
                        break;
                    default:
                        compare = CompareBySum;
                        order = 1;
                        break;
                }

                for (int i = 0; i < array.Length  - 1; i++)
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j] == null)
                            Swap(ref array[j], ref array[j + 1]);
                        else if (array[j + 1] == null)
                            continue;
                        else if (compare(array[j], array[j + 1]) == order)
                            Swap(ref array[j], ref array[j + 1]);
                    }
            }
        }

        }
}
