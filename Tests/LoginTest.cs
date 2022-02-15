using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using System;
using System.Net;
using System.Threading;

namespace Tests
{
    class LoginTest : BaseTests
    {
        [Test]
        public void FitOnlineBrandTest()
        {
            MainPage main = new MainPage(driver);
            Login login = new Login(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickBtnLogin();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='sign']")));
            login.InputEmail();
            login.InputPassword();
            login.ClickLoginBtn();
            IWebElement SearchResult3 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/h1")));
            string actual1 = login.GetLoginResult();
            login.ClickLogoutBtn();
            IWebElement SearchResult4 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/div/h1/a")));
            string actual2 = login.GetLogoutResult();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual1, basepage.loginResult, "Login fail");
                Assert.AreEqual(actual2, basepage.logoutResult, "Logout fail");
            });
        }
    }
}
