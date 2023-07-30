using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Elements_Manipulation_Forms_
{

    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void FillTheFormsWithCaptcha()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");
            //driver.Manage().Window.Maximize();

            var nameField = driver.FindElement(By.Id("et_pb_contact_name_1"));
            nameField.Clear();
            nameField.SendKeys("Sergey");

            var messageField = driver.FindElement(By.Id("et_pb_contact_message_1"));
            messageField.Clear();
            messageField.SendKeys("Text from Sergey");

            //captcha
            string captchaText = driver.FindElement(By.ClassName("et_pb_contact_captcha_question")).Text;
            double result = SolveEquation(captchaText);

            double SolveEquation(string equation)
            {
                string[] elements = equation.Split(' ');
                double element1 = double.Parse(elements[0]);
                string @operator = elements[1];
                double element2 = double.Parse(elements[2]);

                return element1 + element2;
                
            }

            var resultField = driver.FindElement(By.XPath("//*[@id=\"et_pb_contact_form_1\"]/div[2]/form/div/div/p/input"));
            resultField.Clear();
            resultField.SendKeys(Convert.ToString(result));


            var submitButton = driver.FindElements(By.XPath("//*[@class='et_pb_contact_submit et_pb_button']"));
            submitButton[1].Submit();

            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.Close();
            driver.Quit();

        }


        [TestMethod]
        public void ElementInterrogation()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/simple-html-elements-for-automation/");
            driver.Manage().Window.Maximize();

            var buttonById = driver.FindElement(By.Id("button1"));
            //var targetButton = buttonById[0];
            Assert.AreEqual("submit", buttonById.GetAttribute("type"));

            Assert.AreEqual("normal", buttonById.GetCssValue("letter-spacing"));

            Assert.IsTrue(buttonById.Displayed);

            Assert.IsTrue(buttonById.Enabled);

            Assert.IsFalse(buttonById.Selected);

            Assert.AreEqual(buttonById.Text, "Click Me!");

            Assert.AreEqual("button", buttonById.TagName);

            Assert.AreEqual(22, buttonById.Size.Height);

         //   Assert.AreEqual(304, buttonById.Location.X);

         //   Assert.AreEqual(169, buttonById.Location.Y);


            driver.Close();
            driver.Quit();

        }


        }
    }
