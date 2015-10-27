using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Jagged_array
{
    public enum SortingType
    {
        Ascending, Descending
    }

    public abstract class AbstractJaggedComparator<T> : IJagedComparer<T>
    {
       private Dictionary<object, double> dictionary;
        public SortingType SortType
        {
            get;
            set;
        }
       
        protected AbstractJaggedComparator(SortingType type)
        {
             dictionary = new Dictionary<object, double>();
             SortType = type;
        }

        public int Compare(T[] a, T[] b)
        {
            double a_c, b_c;
            if (a == null && b == null)
                return 0;
            if (a == null)
                return 1;
            if (b == null)
                return -1;

            if (!dictionary.TryGetValue(a, out a_c))
            {
                a_c = GetComparsionFeature(a);
                dictionary.Add(a, a_c);
            }
            if (!dictionary.TryGetValue(b, out b_c))
            {
                b_c = GetComparsionFeature(b);
                dictionary.Add(b, b_c);
            }
            switch (SortType)
            {
                case SortingType.Descending:
                    return a_c < b_c ? 1 : a_c > b_c ? -1 : 0;
                case SortingType.Ascending:
                default:
                    return a_c > b_c ? 1 : a_c < b_c ? -1 : 0;
            }
           
        }

       protected abstract double GetComparsionFeature(T[] a);
       
    }
}
