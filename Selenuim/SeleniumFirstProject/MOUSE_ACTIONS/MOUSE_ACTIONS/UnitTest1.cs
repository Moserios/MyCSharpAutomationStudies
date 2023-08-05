using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V113.Debugger;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Security.AccessControl;
using Assert = NUnit.Framework.Assert;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace MOUSE_ACTIONS
{
    [TestFixture]
    public class Mouser_Actions
    {
        private Actions _actions;
        private ChromeDriver _driver;
        private WebDriverWait _wait;


        [Test]
        public void DragAndDrop1()
        {
            _driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            _wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));
            IWebElement targetElement = _driver.FindElement(By.Id("droppable"));
            IWebElement sourceElement = _driver.FindElement(By.Id("draggable"));
            _actions.DragAndDrop(sourceElement, targetElement).Perform();

            Assert.AreEqual("Dropped!", targetElement.Text);
        }

        [Test]
        public void DragAndDrop2()
        {
            _driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            _wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));
            IWebElement targetElement = _driver.FindElement(By.Id("droppable"));
            IWebElement sourceElement = _driver.FindElement(By.Id("draggable"));
            
            var _drag = _actions
                .ClickAndHold(sourceElement)
                .MoveToElement(targetElement)
                .Release(targetElement)
                .Build();

            _drag.Perform();

            Assert.AreEqual("Dropped!", targetElement.Text);
        }

        [Test]
        public void DragAndDrop3_HTML5()
        {
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
            _wait.Until(ExpectedConditions.ElementIsVisible(By.Id("column-a")));
            var jsFile = File.ReadAllText(@"D:\Dropbox\___IT\_automation\drag_n_drop_helper_for_html5.js");
            IJavaScriptExecutor js = _driver;                      
            js.ExecuteScript(jsFile + "$('#column-a').simulateDragDrop({ dropTarget: '#column-b'});");

            Assert.AreEqual("A", _driver.FindElement(By.XPath("//*[@id='column-b']/header")).Text);
        }

        [Test]
        public void Draw_HTML5()
        {
            _driver.Navigate().GoToUrl("https://testpages.herokuapp.com/styled/gui-scribble.html");
            _wait.Until(ExpectedConditions.ElementIsVisible(By.Id("canvas")));
            IWebElement canvasField = _driver.FindElement(By.Id("canvas"));
            Actions builder = new Actions(_driver);
            builder.ClickAndHold(canvasField).MoveByOffset(50,50).MoveByOffset(100, 100).Release().Perform();
          

            Assert.IsTrue(_driver.FindElement(By.XPath("//*[@id='draweventslist']/li[1]")).Enabled);
        }

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _actions = new Actions(_driver);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            _driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }

    }
}
