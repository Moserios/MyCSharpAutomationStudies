using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ExplicitWaits
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/");
            driver.Manage().Window.Maximize();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var firstElementToSync = By.XPath("//*[@id='post-217173']/div/div[1]/div/div[3]/div[2]/div[2]/div[2]");
            wait.Until(ExpectedConditions.ElementToBeClickable(firstElementToSync));

            //wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Automation Exercises"))).Click();
            driver.Navigate().GoToUrl("https://ultimateqa.com/automation/");
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Big page with many elements"))).Click();

            //driver.FindElement(By.XPath("//*[@href='.. / complicated - page']")).Click();

            var lastElementToSync = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@src=\'https://ultimateqa.com/wp-content/uploads/2020/11/01_Ultimate-QA_Logo_V1_rp.png\']")));
            Assert.IsTrue(lastElementToSync.Displayed);

            driver.Close();
            driver.Quit();

            
        }
    }
}
