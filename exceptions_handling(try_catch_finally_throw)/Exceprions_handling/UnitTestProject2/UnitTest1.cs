using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestProject2;

namespace Exceptions_Test

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calculate_BMI()
        {
            string weight = "150";
            string heightInFeet = "6";
            string heightInInch = "72";

            BodyMassIndexCalculator bmi = new BodyMassIndexCalculator
               (int.Parse(weight), int.Parse(heightInFeet), int.Parse(heightInInch));
            string result = bmi.ToString();



            try
            {
                Exception innerException = null;
               Assert.AreEqual("BMI: 5.09", result);

            }
            catch(Exception ex)
            {
                string replacement = result.TrimStart('\n');
                Assert.AreEqual("BMI: 5.09", replacement);
                Console.WriteLine($"Expected value: 'BMI: 5.09'");
                Console.WriteLine($"Actual value: '{replacement}'");
                Console.WriteLine(ex.Message );
            }
        }
    }
}
