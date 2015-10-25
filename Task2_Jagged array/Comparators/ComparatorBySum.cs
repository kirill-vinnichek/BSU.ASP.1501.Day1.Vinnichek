using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Jagged_array.Comparators
{
    public class ComparatorBySum : AbstractJaggedComparator<int>
    {
        public ComparatorBySum()
            : this(SortingType.Ascending)
        {

        }

        public ComparatorBySum(SortingType type)
            : base(type)
        {
            
        }

        protected override double GetComparsionFeature(int[] a)
        {
            return a.Sum();
        }
    }
}
