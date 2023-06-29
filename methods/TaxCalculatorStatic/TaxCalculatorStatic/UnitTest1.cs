using Microsoft.VisualStudio.TestTools.UnitTesting;
using PropertyTaxCalculator;
using System;

namespace TaxCalculatorStatic
{
    [TestClass]
    public class TaxCalculator
    {

        [TestMethod]
        public void TaxableValueCalculation()
        {
            decimal taxableValue = PropertyTax.TaxableValue(1000000.00M, 1.5M, 50000.00M);
            Console.WriteLine(taxableValue);
            Assert.AreEqual(965000.00M, PropertyTax.TaxableValue(1000000.00M, 1.5M, 50000.00M));

        }

        [TestMethod]
        public void PropertyTaxCalculation()
        {
            string taxes = PropertyTax.TaxSpecification("US, FL, Palm Coast 15015", 1000000.00M, 1.5M, 50000.00M, 12.45M);
            Console.WriteLine(taxes);
            Assert.AreEqual(12014.25M, PropertyTax.TaxSize(1000000.00M, 1.5M, 50000.00M, 12.45M));
         
        }

        [TestMethod]
        public void PropertyTaxSpecifivcations()
        {
            string taxes1 = PropertyTax.TaxSpecification("US, FL, Palm Coast 15015", 300000.00M, 1.5M, 50000.00M, 12.45M);
            Console.WriteLine(taxes1);

            string taxes2 = PropertyTax.TaxSpecification("US, CA, Sunnivail 12021", 2500000.00M, 2.5M, 150000.00M, 6.45M);
            Console.WriteLine(taxes2);

            string taxes3 = PropertyTax.TaxSpecification("US, WA, Seattle 14041", 930000.00M, 0.75M, 35000.00M, 8.94M);
            Console.WriteLine(taxes3);

        }




    }
}
