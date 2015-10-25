using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Jagged_array.Comparators
{
   public class ComparatorByMaxElement:AbstractJaggedComparator<int>
    {
         public ComparatorByMaxElement()
            : this(SortingType.Ascending)
        {

        }

         public ComparatorByMaxElement(SortingType type)
            : base(type)
        {

        }

        protected override double GetComparsionFeature(int[] a)
        {
            return a.Max();
        }
    }
}
