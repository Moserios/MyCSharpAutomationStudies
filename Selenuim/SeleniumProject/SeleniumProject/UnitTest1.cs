using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumProject
{
    [TestClass]
    public class URLs
    {
        [TestMethod]
        public void GmailLogin()
        {
            var driver = GetChromeDriver();
            driver.Navigate().GoToUrl("https://mail.google.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            
            var nameField = driver.FindElement(By.CssSelector("#identifierId"));
            nameField.Clear();
            nameField.SendKeys("seltelacc@gmail.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            var nButton = driver.FindElement(By.XPath("//*[@id=\"identifierNext\"]/div/button/span"));
            nButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            var passwordField = driver.FindElement(By.Name("Passwd"));
            passwordField.Clear();
            passwordField.SendKeys("SeleniumTestAccount123");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            var pButton = driver.FindElement(By.XPath("//*[@id=\"password\"]/div[1]/div/div[1]/input"));
            pButton.Click();
            //driver.FindElement(By.Id("identifier"));

            //driver.
            // id: identifierId
        }

        [TestMethod]
        public void YahooLogin()
        {
            var driver = GetChromeDriver();
            driver.Navigate().GoToUrl("https://login.yahoo.com/");
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            var nameField = driver.FindElement(By.CssSelector("#login-username"));
            nameField.Clear();
            nameField.SendKeys("moserius");
            var nButton = driver.FindElement(By.CssSelector("#login-signin"));
            nButton.Click();

            var passwordField = driver.FindElement(By.ClassName("password"));
            passwordField.Clear();
            passwordField.SendKeys("Moserios1249");
            var pButton = driver.FindElement(By.XPath("//*[@id=\"login-signin\"]"));
            pButton.Click();
            //driver.FindElement(By.Id("identifier"));

            //driver.
            // id: identifierId
        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}
