using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using System;
using System.Net;
namespace Tests
{
    class DemoPageBtnVerification : BaseTests
    {
        [Test]
        public void DemoPageDemoStoreLink()
        {
            MainPage main = new MainPage(driver);
            DemoStore demostore = new DemoStore(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderDemoStore();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/p[3]/a/img")));
            string link = demostore.GetDemoStoreLink();
            string actual = link;
            string expected = basepage.urlDemoStore;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the Link");
                Assert.AreEqual(myHttpWebResponse.StatusCode, HttpStatusCode.OK,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void DemoPageMySizeButtonLink()
        {
            MainPage main = new MainPage(driver);
            DemoStore demostore = new DemoStore(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderDemoStore();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/p[3]/a/img")));
            string link = demostore.GetMySizeButtonLink();
            string actual = link;
            string expected = basepage.urlDemoStoreCatalog;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the Link");
                Assert.AreEqual(myHttpWebResponse.StatusCode, HttpStatusCode.OK,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void DemoPageSizingWidgetLink()
        {
            MainPage main = new MainPage(driver);
            DemoStore demostore = new DemoStore(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderDemoStore();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/p[3]/a/img")));
            string link = demostore.GetSizingWidgetLink();
            string actual = link;
            string expected = basepage.urlDemoStoreProduct;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the Link");
                Assert.AreEqual(myHttpWebResponse.StatusCode, HttpStatusCode.OK,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void DemoPageMySizeBtn()
        {
            MainPage main = new MainPage(driver);
            DemoStore demostore = new DemoStore(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderDemoStore();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/p[3]/a/img")));
            string link = demostore.GetMySizeButtonBtn();
            string actual = link;
            string expected = basepage.urlDemoStoreCatalog;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the button");
                Assert.AreEqual(myHttpWebResponse.StatusCode, HttpStatusCode.OK,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void DemoPageSizingWidgetBtn()
        {
            MainPage main = new MainPage(driver);
            DemoStore demostore = new DemoStore(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderDemoStore();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/p[3]/a/img")));
            string link = demostore.GetSizingWidgetBtn();
            string actual = link;
            string expected = basepage.urlDemoStoreProduct;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the button");
                Assert.AreEqual(myHttpWebResponse.StatusCode, HttpStatusCode.OK,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void DemoPageImage()
        {
            MainPage main = new MainPage(driver);
            DemoStore demostore = new DemoStore(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderDemoStore();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/p[3]/a/img")));
            string link = demostore.GetDemoStoreImage();
            string actual = link;
            string expected = basepage.urlDemoStoreImage;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected,actual, "Wrong URL in the image");
            });
        }
    }
}
