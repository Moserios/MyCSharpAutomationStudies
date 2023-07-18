using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingElementPage
{
    [TestClass]
    public class FinalExam
    {
        [TestMethod]
        public void TestComplicatedPage()
        {
            ComplicatedPage complicatedPage = new ComplicatedPage();
            string pagename = complicatedPage.PageName;
            Assert.AreEqual("Complicated Page", pagename);
        }

        [TestMethod]
        public void TestSectionOfRandomStuff()
        {
            SectionOfRandomStuff sectionOfRandomStuff = new SectionOfRandomStuff();
            sectionOfRandomStuff.FillForm();
        }

        [TestMethod]
        public void TestSectionOfButtons()
        {
            SectionOfButtons sectionOfButtons = new SectionOfButtons();
            try
            {
                sectionOfButtons.Button.Click();
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.ToString());   
            }
        }
    }
}
