using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.Timers;
using OpenQA.Selenium.Support.Extensions;

namespace ClickTheElement
{
    [TestClass]
    [TestCategory("Locating web elements")]
    public class IdentifyingWebElements
    {
        //public IWebDriver Driver { get; private set; }

        //[TestInitialize]
        //public void SetBeforeTest()
        //{
        //    //Driver = new WebDriverFactory().Create(BrowserType.Chrome);
        //    var driver = new ChromeDriver();
        //}

        [TestMethod]
        public void ClickElementWithDifferentTypes()
        {
            var driver = new ChromeDriver();
            // var element = null;
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/simple-html-elements-for-automation/");
            driver.Manage().Window.Maximize();

            // Doesn't work as it explained in the course!!! This guys just didn't want to show how it really works! Never use element for identification if it more than one!
            //var ln = driver.FindElements(By.ClassName("et_pb_blurb_description"))[4];
            //ln.Click();
            //Thread.Sleep(TimeSpan.FromSeconds(2));
            //driver.Navigate().Back();

            driver.FindElement(By.Id("simpleElementsLink")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.Navigate().Back();

            driver.FindElement(By.LinkText("Click this link")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.Navigate().Back();

            driver.FindElement(By.Name("clickableLink")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.Navigate().Back();

            driver.FindElement(By.PartialLinkText("Click this l")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.Navigate().Back();

            //var linkTag = driver.FindElements(By.TagName("a"))[371];
            //Thread.Sleep(TimeSpan.FromSeconds(2));
            //driver.Navigate().Back();

            driver.FindElement(By.CssSelector("#simpleElementsLink")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.Navigate().Back();

            driver.FindElement(By.XPath("//*[@id='simpleElementsLink']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            driver.Close();
            driver.Quit();
            //  driver.FindElement(By.XPath("//button[@class='buttonClass']")).Click();
            // driver.FindElement(By.CssSelector(".buttonClass")).Click();




        }

        [TestMethod]
        public void ClickElementsWithXPathExam()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/simple-html-elements-for-automation/");
            driver.Manage().Window.Maximize();


            //radio button
            var element = driver.FindElement(By.XPath("//*[@type='radio'][@name='gender'][@value='male']"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            driver.FindElement(By.XPath("//*[@type='radio'][@name='gender'][@value='male']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            //checkbox
            var element2 = driver.FindElement(By.XPath("//*[@type='checkbox'][@name='vehicle'][@value='Car']"));
            Actions actions2 = new Actions(driver);
            actions2.MoveToElement(element2);
            driver.FindElement(By.XPath("//*[@type='checkbox'][@name='vehicle'][@value='Car']")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            //dropdown
            var element3 = driver.FindElement(By.XPath("//*[@class='et_pb_blurb_description']/child::select"));
            Actions actions3 = new Actions(driver);
            actions3.MoveToElement(element3);
            driver.FindElement(By.XPath("//*[@class='et_pb_blurb_description']/child::select")).Click();
            driver.FindElement(By.XPath("//*[@class='et_pb_blurb_description']/child::select/child::option[4]")).Click(); // //   "//*[@@value='audi']"
            Thread.Sleep(TimeSpan.FromSeconds(2));

            //Open Tab2 and verify that Tab2 page is opened
            var element4 = driver.FindElement(By.XPath("//*[@class='et_pb_tab_1']/child::a")); //  //*[contains(text(), 'Tab 2')]/parent::li   //  //*[@class='et_pb_tab_1']/child::a"
            Actions actions4 = new Actions(driver);
            actions4.MoveToElement(element4);
            driver.FindElement(By.XPath("//*[@class='et_pb_tab_1']/child::a")).Click();
            String currentText = driver.FindElement(By.XPath("//*[@class='et_pb_tab et_pb_tab_1 clearfix et-pb-active-slide']")).Text;
            Assert.AreEqual("Tab 2 content", currentText);
            Thread.Sleep(TimeSpan.FromSeconds(2));

            driver.Close();
            driver.Quit();


        }

        [TestMethod]
        public void CheckElementInSecondTableExam()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/simple-html-elements-for-automation/");
            // driver.Manage().Window.Maximize();
            //Open top Table and check 2nd value
            var element = driver.FindElement(By.XPath("//h2[contains(text(),'no id')]/following-sibling::table//td[contains(text(),'$120,000+')]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            Assert.IsTrue(driver.FindElement(By.XPath("//h2[contains(text(),'no id')]/following-sibling::table//td[contains(text(),'$120,000+')]")).Displayed);
            Thread.Sleep(TimeSpan.FromSeconds(2));

            driver.Close();
            driver.Quit();

        }

        [TestMethod]
        public void CheckElementInFirstTableExam()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/simple-html-elements-for-automation/");
            driver.Manage().Window.Maximize();
            //Open top Table and check 2nd value
            //var element = driver.FindElement(By.XPath("//h2[contains(text(),'HTML Table with unique id')]/following-sibling::table//td[contains(text(),'$120,000+')]"));
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(element);
            Assert.IsTrue(driver.FindElement(By.XPath("//table[@id='htmlTableId']//td[text()='Automation Testing Architect']//following-sibling::td[2]")).Text.Equals("$120,000+"));
            Thread.Sleep(TimeSpan.FromSeconds(2));

            driver.Close();
            driver.Quit();

        }

        [TestMethod]
        public void CheckElementContainsTextExam()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/simple-html-elements-for-automation/");
            driver.Manage().Window.Maximize();

            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='button1'][text()='Click Me!']/parent::form//preceding-sibling::h3")).Text.Equals("This section has really simple HTML elements so that you can understand their basic nature. Feel free to practice your test automation on these elements."));

            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.Close();
            driver.Quit();

        }

        [TestMethod]
        public void CheckLastElementInTableIsForQA()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/simple-html-elements-for-automation/");
            driver.Manage().Window.Maximize();

            Assert.IsTrue(driver.FindElement(By.XPath("//table[@id='htmlTableId']/tbody/tr[last()]/td[1]")).Text.Equals("Quality Assurance Engineer"));

            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.Close();
            driver.Quit();

        }
    }

}