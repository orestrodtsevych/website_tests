using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;
namespace Tests
{
    public class BaseTests
    {

        protected IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Size = new Size(1920, 1080);
            driver.Navigate().GoToUrl("https://www.looksize.com/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
