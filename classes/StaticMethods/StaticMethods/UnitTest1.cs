using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.CompilerServices;

namespace StaticMethods
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void TestSquareRoot()
        {
            double result = MathFunctions.SquareRoot(10);
            Assert.AreEqual(result, 3.1623, 0.0001);
            Console.WriteLine(result);
        }

        [TestMethod]
        public void SumInt()
        {
            int result = MathFunctions.Sum(10);
            Assert.AreEqual(20, result);
            Console.WriteLine(result);
        }

        [TestMethod]
        public void SumDouble()
        {
            double result = MathFunctions.Sum((double)10.55);
            Assert.AreEqual(21.10, result);
            Console.WriteLine(result);
        }

        [TestMethod]
        public void SumDecimal()
        {
            decimal result = MathFunctions.Sum(555.55555M);
            Assert.AreEqual(1111.1111M, result);
            Console.WriteLine(result);
        }
    }
}
