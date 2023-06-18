using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Temperature
{
    [TestClass]
    public class TemperatureConverter
    {
      
        [TestMethod]
        public void ConvertToC()
        {
            double fahrenheit = 57;
            double cTemp = (fahrenheit - 32)*0.5556;
            Console.WriteLine($"{fahrenheit} degrees of Foreingheit is {cTemp} degrees of Celsius.");
            Assert.AreEqual( cTemp, 13.89, 0.001);
        }

        [TestMethod]
        public void ConvertToF()
        {
            double celsius = 12.5;
            double coefficient = 1.8;
            double fTemp = (coefficient * celsius) + 32;
            Console.WriteLine($"{celsius} degrees of Celsius is {fTemp} degrees of Foreingheit.");
            Assert.AreEqual(fTemp, 54.5, 0.001);
        }
    }
}

