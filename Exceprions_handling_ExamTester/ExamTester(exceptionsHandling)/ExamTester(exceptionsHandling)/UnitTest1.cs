using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExamTester_exceptionsHandling_
{
    [TestClass]
    public class ExamTester
    {
        //create a Try/Catch block in each test that calls the method and catches the specific exception that is produced.
        //Each method should be handled so that if an exception accur, the test will still pass.



        [TestMethod]
        public void Test_Weekly_Wages()
        {
            try 
            { 
                ExamHelper.WeeklyWages();
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void Test_Calc_Result()
        {
            try
            {
                ExamHelper.CalculateResult();
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void Test_Number_Check()
        {
            try
            {
                ExamHelper.NumberCheck();
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
