using System;
using NUnit.Framework;
using System.Collections;
using Task2_Jagged_array;
using Task2_Jagged_array.Comparators;
namespace Task2.Test
{
    [TestFixture]
    public class SortTest
    {
       
     
        [Test]
        [ExpectedException("System.ArgumentNullException")]
        public void TestNull()
        {
            int[][] ar = null;
            DelegateToInterfaceSort.Sort(ar,new ComparatorBySum(SortingType.Ascending));
            DelegateToInterfaceSort.Sort(ar, ComparatorByMaxElement.Compare);

        }

        [Test]
        public void TestSumAsc()
        {
            int[][] ar = new[] { new[] { 1 }, null, null, new[] { -2, 7, 5 }, null, new[] { 40, 2 } };
            int[][] test = new[] { new[] { 1 },new[] { -2, 7, 5 }, new[] { 40, 2 }, null, null, null };

            DelegateToInterfaceSort.Sort(ar,new ComparatorBySum(SortingType.Ascending));
            InterfaceToDelegateSort.Sort(ar, new ComparatorBySum(SortingType.Ascending));
            IStructuralEquatable eq = ar;
            Assert.AreEqual(eq.Equals(test, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [Test]
        public void TestSumDesc()
        {
            int[][] ar = new[] { new[] { 1 }, null, null, new[] { -2, 7, 5 }, null, new[] { 40, 2 } };
            int[][] test = new[] { new[] { 40, 2 }, new[] { -2, 7, 5 }, new[] { 1 }, null, null, null };

            DelegateToInterfaceSort.Sort(ar, new ComparatorBySum(SortingType.Descending));
            InterfaceToDelegateSort.Sort(ar, new ComparatorBySum(SortingType.Descending));
            IStructuralEquatable eq = ar;
            Assert.AreEqual(eq.Equals(test, StructuralComparisons.StructuralEqualityComparer), true);
        }
        [Test]
        public void TestMinAsc()
        {
            int[][] ar = new[] { new[] { 1 }, null, null, new[] { -2, 7, 5 }, null, new[] { 40, 2 } };
            int[][] test = new[] { new[] { -2, 7, 5 }, new[] { 1 }, new[] { 40, 2 }, null, null, null };


            InterfaceToDelegateSort.Sort(ar, new ComparatorByMinElement());
            IStructuralEquatable eq = ar;
            Assert.AreEqual(eq.Equals(test, StructuralComparisons.StructuralEqualityComparer), true);
        }
      
    }
}
