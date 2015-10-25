using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Jagged_array.Comparators
{
    public class ComparatorByMinElement : AbstractJaggedComparator<int>
    {
        public ComparatorByMinElement()
            : this(SortingType.Ascending)
        {

        }

        public ComparatorByMinElement(SortingType type)
            : base(type)
        {

        }

        protected override double GetComparsionFeature(int[] a)
        {
            return a.Min();
        }
    }
}
