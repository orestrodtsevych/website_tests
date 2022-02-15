using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using System;
using System.Net;
namespace Tests
{
    class MainPageBtnVerification : BaseTests
    {
        [Test]
        public void MainPageTryFreeBtn1()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetBtnTryFree1();
            string actual = link;
            string expected = basepage.urlHeaderFreeTrial;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the button");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void MainPageTryFreeBtn2()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetBtnTryFree2();
            string actual = link;
            string expected = basepage.urlHeaderFreeTrial;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the button");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void MainPageTryFreeBtn3()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetBtnTryFree3();
            string actual = link;
            string expected = basepage.urlHeaderFreeTrial;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the button");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void MainContactUsLink()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetLinkContactUs();
            string actual = link;
            string expected = basepage.urlHeaderContact;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void MainPlayer()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            //Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickBtnPlayer();
            string link = main.GetBtnPlayerSrc();
            string actual = link;
            string expected = basepage.urlPlayerSrc;
            string actual2 = main.urlPlayerAlt;
            string expected2 = basepage.urlPlayerAlt;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected, actual, "Wrong URL in the button");
                Assert.AreEqual(expected2, actual2, "Player is not working correctly");
            });
        }
    }
}
