using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;

namespace SelenuimStudies
{
    [TestClass]
    public class SeleniumGmail
    {
        [TestMethod]
        public void LoginToGmail()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://gmail.com");
        }
    }
}
