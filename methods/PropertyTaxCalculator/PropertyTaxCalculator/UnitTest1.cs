using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PropertyTaxCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PropertyTaxCalculationChillwack()
        {
            PropertyTax myPropertyTax = new PropertyTax("Chillwack, BC, CA", 500000.00M, 2.7M, 10.03M);

            Console.WriteLine($"Current Assessed Value: {myPropertyTax.CYAssessedValue().ToString("c")}.");
            Console.WriteLine($"Tax size: {myPropertyTax.TaxCalculation().ToString("c")}.");
            Console.WriteLine(myPropertyTax.ToString());
            Assert.AreEqual
        }

        [TestMethod]
        public void PropertyTaxCalculation()
        {
            PropertyTax myPropertyTax = new PropertyTax("Chillwack, BC, CA", 500000.00M, 2.7M, 10.03M);

            Console.WriteLine($"Current Assessed Value: {myPropertyTax.CYAssessedValue().ToString("c")}.");
            Console.WriteLine($"Tax size: {myPropertyTax.TaxCalculation().ToString("c")}.");
            Console.WriteLine(myPropertyTax.ToString());
        }

        [TestMethod]
        public void PropertyTaxCalculation()
        {
            PropertyTax myPropertyTax = new PropertyTax("Chillwack, BC, CA", 500000.00M, 2.7M, 10.03M);

            Console.WriteLine($"Current Assessed Value: {myPropertyTax.CYAssessedValue().ToString("c")}.");
            Console.WriteLine($"Tax size: {myPropertyTax.TaxCalculation().ToString("c")}.");
            Console.WriteLine(myPropertyTax.ToString());
        }
    }
}
