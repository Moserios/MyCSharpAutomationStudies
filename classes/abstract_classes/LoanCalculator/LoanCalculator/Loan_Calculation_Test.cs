using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoanCalculator
{
    [TestClass]
    public class Loan_Calculation_Test
    {
        [TestMethod]
        public void HomeLoneCalculation()
        {
            HomeLoan newHomeloan = new HomeLoan(0001, "Sergey", "Molchun", 210000.00M, 30, 0.035, "San Diego, CA, USA", 1965, "Contemporary", "bricks", 356.3);
            Console.WriteLine($" Monthly interest is: {newHomeloan.CalculateInterest()} .");
            Console.WriteLine();
            Console.WriteLine(newHomeloan);
            Assert.AreEqual(3010, newHomeloan.CalculateInterest());
        }

        [TestMethod]
        public void CarLoneCalculation()
        {
            CarLoan newCarloan = new CarLoan(0002, "Sergey", "Molchun", 12000.00M, 4, 0.075, "Toyota", 2022, "Prius", "gasoline", 30);
            Console.WriteLine($" Monthly interest is: {newCarloan.CalculateInterest()} $.");
            Console.WriteLine();
            Console.WriteLine(newCarloan);
            Assert.AreEqual(2925, newCarloan.CalculateInterest());
        }
    }
}
