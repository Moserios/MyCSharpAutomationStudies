using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Loops
{
    [TestClass]
    public class UnitTestLoop
    {
        [TestMethod]
        public void Nested_Loops()
        {
            int number1 = 0;          
            while(number1 < 3)
            {
                int number2 = 10;
                while (number2 > 5)
                {
                    Console.WriteLine($"Outer: {number1}    Inner: {number2--}");                  
                }  
                //number2 = 10;
                //Console.WriteLine($"Outer: {number1}    Inner: {number2}");
            } 
        }
    }


    [TestClass]
    public class CalculateRetailPrice
    {
        [TestMethod]
        public void RetailPrice()
        {
            int percentage = 5;
            //public int percentageEndNumber = 10;
            ItemPrice retailItemPrice = new ItemPrice(100);
            for (percentage = 5; percentage <= 10; percentage++)                
            {
                Console.WriteLine($"Wholesale price is {retailItemPrice.WholesalePrice}. Retail price with profit of: {percentage}% is: {retailItemPrice.WholesalePrice /100 * (100 + percentage)}");
               // int percentage++;
            }
        }
    }
}
