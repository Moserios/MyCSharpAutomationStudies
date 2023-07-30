using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.Timers;
using OpenQA.Selenium.Support.Extensions;

namespace Navigation
{
    [TestClass]
    public class NavigationTest
    {
        [TestMethod]
        public void CheckTitle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.ultimateqa.com");
            string elementValue = driver.Title;
            //string elementValue = driver.FindElement(By.XPath("//*[@title]/preceding-sibling::title")).Text;
            //Assert.AreEqual(driver.FindElement(By.XPath("//*[@title]/preceding-sibling::title")).Text,"Homepage - Ultimate QA");
            Assert.IsTrue(driver.Title.Equals("Homepage - Ultimate QA"));
            Thread.Sleep(TimeSpan.FromSeconds(2));

            driver.Navigate().GoToUrl("https://ultimateqa.com/automation/");
           //string elementValueAutomation = driver.FindElement(By.XPath("//*[@title]/preceding-sibling::title")).Text;
            Assert.IsTrue(driver.Title.Equals("Automation Practice - Ultimate QA"));
            Thread.Sleep(TimeSpan.FromSeconds(2));

            //driver.Navigate().GoToUrl("https://ultimateqa.com/automation/");
            driver.FindElement(By.XPath("//*[@href='../complicated-page']")).Click();
            //Assert.IsTrue(driver.Title.Equals("Complicated Page - Ultimate QA"));
            //Thread.Sleep(TimeSpan.FromSeconds(2));

            //driver.Navigate().GoToUrl("https://ultimateqa.com/automation/");
            //string elementValueComplecated = driver.FindElement(By.XPath("//*[@title]/preceding-sibling::title")).Text;
            Assert.IsTrue(driver.Title.Equals("Complicated Page - Ultimate QA"));
            Thread.Sleep(TimeSpan.FromSeconds(2));

            driver.Navigate().Back();
            string elementTitle = driver.Title;
            Assert.AreEqual("Automation Practice - Ultimate QA", elementTitle);
            Thread.Sleep(TimeSpan.FromSeconds(2));


            driver.Close();
            driver.Quit();

        }
    }
}
