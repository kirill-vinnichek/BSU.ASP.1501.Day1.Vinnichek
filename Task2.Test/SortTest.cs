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
        public void TestNull()
        {
            int[][] ar = null;
            IJagedCompare<int> c = new ComparatorBySum(SortingType.Ascending);
            ar.Sort(c);

        }

        [Test]
        public void TestSumAsc()
        {
            int[][] ar = new[] { new[] { 1 }, null, null, new[] { -2, 7, 5 }, null, new[] { 40, 2 } };
            int[][] test = new[] { new[] { 1 },new[] { -2, 7, 5 }, new[] { 40, 2 }, null, null, null };

            IJagedCompare<int> c = new ComparatorBySum(SortingType.Ascending);
            ar.Sort(c);
            IStructuralEquatable eq = ar;
            Assert.AreEqual(eq.Equals(test, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [Test]
        public void TestSumDesc()
        {
            int[][] ar = new[] { new[] { 1 }, null, null, new[] { -2, 7, 5 }, null, new[] { 40, 2 } };
            int[][] test = new[] { new[] { 40, 2 }, new[] { -2, 7, 5 }, new[] { 1 }, null, null, null };

            IJagedCompare<int> c = new ComparatorBySum(SortingType.Descending);
            ar.Sort(c);
            IStructuralEquatable eq = ar;
            Assert.AreEqual(eq.Equals(test, StructuralComparisons.StructuralEqualityComparer), true);
        }
        [Test]
        public void TestMinAsc()
        {
            int[][] ar = new[] { new[] { 1 }, null, null, new[] { -2, 7, 5 }, null, new[] { 40, 2 } };
            int[][] test = new[] { new[] { -2, 7, 5 }, new[] { 1 }, new[] { 40, 2 }, null, null, null };

            IJagedCompare<int> c = new ComparatorByMinElement(SortingType.Ascending);
            ar.Sort(c);
            IStructuralEquatable eq = ar;
            Assert.AreEqual(eq.Equals(test, StructuralComparisons.StructuralEqualityComparer), true);
        }
        public void TestMinDesc()
        {
            int[][] ar = new[] { new[] { 1 }, null, null, new[] { -2, 7, 5 }, null, new[] { 40, 2 } };
            int[][] test = new[] { new[] { 40, 2 }, new[] { 1 }, new[] { -2, 7, 5 }, null, null, null };

            IJagedCompare<int> c = new ComparatorByMinElement(SortingType.Descending);
            ar.Sort(c);
            IStructuralEquatable eq = ar;
            Assert.AreEqual(eq.Equals(test, StructuralComparisons.StructuralEqualityComparer), true);
        }
    }
}
