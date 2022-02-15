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
    class MyAccountTest : BaseTests
    {
        [Test]
        public void ChangePasswordTest()
        {
            MainPage main = new MainPage(driver);
            Login login = new Login(driver);
            BasePage basepage = new BasePage(driver);
            MyAccount myaccount = new MyAccount(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickBtnLogin();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='sign']")));
            login.InputEmail();
            login.InputPassword();
            login.ClickLoginBtn();
            IWebElement SearchResult3 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/h1")));
            string actual1 = login.GetLoginResult();
            myaccount.ClickChangePasswordBtn();
            Thread.Sleep(1000);
            myaccount.InputPassword1();
            myaccount.InputPassword2();
            IWebElement SearchResult4 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_form']/div[1]/div[3]/button")));
            myaccount.ClickChangeBtn();
            Thread.Sleep(1000);
            string actual2 = myaccount.GetChangePasswordResult();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual1, basepage.loginResult, "Login fail");
                Assert.AreEqual(actual2, basepage.passwordChangeResult, "Change password fail");
            });
        }

        [Test]
        public void EditProfileTest()
        {
            MainPage main = new MainPage(driver);
            Login login = new Login(driver);
            BasePage basepage = new BasePage(driver);
            MyAccount myaccount = new MyAccount(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickBtnLogin();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='sign']")));
            login.InputEmail();
            login.InputPassword();
            login.ClickLoginBtn();
            IWebElement SearchResult3 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/h1")));
            string actual1 = login.GetLoginResult();
            myaccount.ClickMyAccountBtn();
            IWebElement SearchResult4 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/button")));
            myaccount.ClickEditMyAccountBtn();
            IWebElement SearchResult5 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='btn_submit']")));
            myaccount.ClickUpdateBtn();
            IWebElement SearchResult6 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='content_message']/div")));
            string updateResult = myaccount.GetUpdateResult();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual1, basepage.loginResult, "Login fail");
                Assert.AreEqual(updateResult, basepage.accountEditResult, "Edit account fail");
            });
        }

        [Test]
        public void ValidateMyAccountButtons()
        {
            MainPage main = new MainPage(driver);
            Login login = new Login(driver);
            BasePage basepage = new BasePage(driver);
            MyAccount myaccount = new MyAccount(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickBtnLogin();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='sign']")));
            login.InputEmail();
            login.InputPassword();
            login.ClickLoginBtn();
            IWebElement SearchResult3 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/h1")));
            string actual1 = login.GetLoginResult();
            
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual1, basepage.loginResult, "Login fail");
                //Assert.AreEqual(actual2, basepage.passwordChangeResult, "Change password fail");
            });
        }


        [Test]
        public void MyAccountDetermineSizeBtn()
        {
            MainPage main = new MainPage(driver);
            Login login = new Login(driver);
            BasePage basepage = new BasePage(driver);
            MyAccount myaccount = new MyAccount(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickBtnLogin();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='sign']")));
            login.InputEmail();
            login.InputPassword();
            login.ClickLoginBtn();
            IWebElement SearchResult3 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/h1")));
            string actual1 = login.GetLoginResult();
            string actual = myaccount.GetDetermineTheSizeBtn();
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(actual);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual1, basepage.loginResult, "Login fail");
                Assert.AreEqual(actual, basepage.urlDetermineTheSize, "Wrong URL in the button");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode, actual + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        //////////////////////////////////////////////////////////////////

        [Test]
        public void ChangePasswordTestLeft()
        {
            MainPage main = new MainPage(driver);
            Login login = new Login(driver);
            BasePage basepage = new BasePage(driver);
            MyAccount myaccount = new MyAccount(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickBtnLogin();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='sign']")));
            login.InputEmail();
            login.InputPassword();
            login.ClickLoginBtn();
            IWebElement SearchResult3 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/h1")));
            string actual1 = login.GetLoginResult();
            myaccount.ClickChangePasswordBtnLeft();
            Thread.Sleep(1000);
            myaccount.InputPassword1();
            myaccount.InputPassword2();
            IWebElement SearchResult4 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_form']/div[1]/div[3]/button")));
            myaccount.ClickChangeBtn();
            Thread.Sleep(1000);
            string actual2 = myaccount.GetChangePasswordResult();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual1, basepage.loginResult, "Login fail");
                Assert.AreEqual(actual2, basepage.passwordChangeResult, "Change password fail");
            });
        }

        [Test]
        public void EditProfileTestLeft()
        {
            MainPage main = new MainPage(driver);
            Login login = new Login(driver);
            BasePage basepage = new BasePage(driver);
            MyAccount myaccount = new MyAccount(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickBtnLogin();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='sign']")));
            login.InputEmail();
            login.InputPassword();
            login.ClickLoginBtn();
            IWebElement SearchResult3 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/h1")));
            string actual1 = login.GetLoginResult();
            myaccount.ClickMyAccountBtnLeft();
            IWebElement SearchResult4 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/button")));
            myaccount.ClickEditMyAccountBtn();
            IWebElement SearchResult5 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='btn_submit']")));
            myaccount.ClickUpdateBtn();
            IWebElement SearchResult6 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='content_message']/div")));
            string updateResult = myaccount.GetUpdateResult();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual1, basepage.loginResult, "Login fail");
                Assert.AreEqual(updateResult, basepage.accountEditResult, "Edit account fail");
            });
        }
    }
}
