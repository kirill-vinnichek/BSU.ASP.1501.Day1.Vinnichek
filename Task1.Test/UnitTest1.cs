using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1_NewtonMethod;
namespace Task1.Test
{
    [TestClass]
    public class NewtonMethodTest
    {
        [TestMethod]
        public void TestInt()
        {
            Assert.AreEqual(NewtonMethod.RootExtract(27, 3,0.00001), Math.Pow(27, 1.0/ 3), 0.00001);
        }
        [TestMethod]
        public void TestDouble()
        {
            Assert.AreEqual(NewtonMethod.RootExtract(0.81, 2, 0.00001), Math.Pow(0.81, 1.0 / 2), 0.00001);
        }
        [TestMethod]
        public void TestNan()
        {
            Assert.AreEqual(NewtonMethod.RootExtract(-9, 2, 0.00001), Math.Pow(-9, 1.0 / 2));
            Assert.AreEqual(NewtonMethod.RootExtract(double.NaN, 0, 0.00001), Double.NaN);
        }
        [TestMethod]
        public void TestAlwaysOne()
        {
            Assert.AreEqual(NewtonMethod.RootExtract(-123129, 0, 0.00001), 1);
        }
        [TestMethod]
        public void TestZero()
        {
            Assert.AreEqual(NewtonMethod.RootExtract(0, 123, 0.00001), 0);
        }
    }
}
