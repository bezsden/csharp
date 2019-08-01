using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Selenium.Tests
{
    //[TestFixture]
    public class NUnitTest
    {
        private IWebDriver driver;

        public NUnitTest()
        {
            driver = new ChromeDriver();
        }

        [SetUp]
        public void Initialize()
        {
            driver.Url = "http://google.com";
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void OpenAppTest()
        {
            var searchInputField = driver.FindElement(By.XPath("//input[@type='text']"));
                searchInputField.SendKeys("anime");
                searchInputField.Submit();
                Thread.Sleep(10000);
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
