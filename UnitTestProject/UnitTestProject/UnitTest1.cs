using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory ("UnitTests")]
    
    public class UnitTests_Part1
    {
        public TestContext TestContext { get; set; }
        public static TestContext _testContext;
        private int a;
        private int b;

        [TestInitialize]
        public void RunBeforeEveryTest()
        {
            a = 1;
            b = 2;  
        }

        [TestCleanup]
        public void RunAfterEveryTestMethod()
        {
            Trace.WriteLine("Cleaning after method");
        }

        [ClassInitialize]
        public static void RunBeforeEveryClass(TestContext testContext)
        {
            _testContext = testContext;
            Trace.WriteLine("Runnig only once before all tests in Class started");
        }

        [ClassCleanup]
        public static void RunAfterEveryTestClass()
        {
            Trace.WriteLine("Cleaning after Class");
        }

        [TestMethod]
        [TestCategory("positive")]
        [Description("these are description for TestMethod")]
        public void AssertAreEqual()
        {
            Assert.AreEqual(3, a + b);
       //     Console.WriteLine($"Running test AssertAreEqual.");
            Trace.Write(TestContext.CurrentTestOutcome);
        }

        [TestMethod]
        [TestCategory("negative")]
        public void AssertIsTrue()
        {
            Assert.IsTrue(3 == (a + b));
          //  Console.WriteLine($"Running test AssertIsTrue.");
            Trace.Write(TestContext.CurrentTestOutcome);
        }

        [TestMethod]
        [TestCategory("negative")]
        [ExpectedException(typeof(AssertFailedException))]
        public void AssertFailedException()
        {
            Assert.AreEqual(2, a + b);
         //   Console.WriteLine($"Running test AssertFailedException.");
            Trace.WriteLine(TestContext.TestName);
        }

        [TestMethod]
        [TestCategory("negative")]
        [ExpectedException(typeof(AssertFailedException))]
        public void AlwaysFailingCase()
        {
            Assert.Fail();
        //    Console.WriteLine($"Running test AlwaysFailingCase.");
            Trace.WriteLine(TestContext.CurrentTestOutcome);
        }
    }
}
