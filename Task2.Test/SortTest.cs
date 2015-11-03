using System;
using NUnit.Framework;
using System.Collections;
using Task2_Jagged_array;
using Task2_Jagged_array.Comparators;
using System.Linq;
using System.Collections.Generic;
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
            DelegateToInterfaceSort.Sort(ar,
                (a, b) =>
                {
                    double a_c, b_c;
                    if (a == null && b == null)
                        return 0;
                    if (a == null)
                        return 1;
                    if (b == null)
                        return -1;

                    a_c = a.Max();

                    b_c = b.Max();

                    return a_c > b_c ? -1 : a_c < b_c ? 1 : 0;
                });
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
      
         public class Comp:IComparer<string>
        {

             public int Compare(string x, string y)
             {
                 throw new NotImplementedException();
             }
        }

        [Test]
         public void TestStringSortDTI()
        {
        
            string[] ar = new[] {"b", "a" };
            string[] test = new[] { "a", "b" };
            DelegateToInterfaceSort.Sort(ar, (Comp)null);
            IStructuralEquatable eq = ar;
            Assert.AreEqual(eq.Equals(test, StructuralComparisons.StructuralEqualityComparer), true);
        }
        [Test]
        public void TestStringSortITD()
        {

            string[] ar = new[] { "b", "a" };
            string[] test = new[] { "a", "b" };
            InterfaceToDelegateSort.Sort(ar, (Comparison<string>)null);
            IStructuralEquatable eq = ar;
            Assert.AreEqual(eq.Equals(test, StructuralComparisons.StructuralEqualityComparer), true);
        }
    }
}
