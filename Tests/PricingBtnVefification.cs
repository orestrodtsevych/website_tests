using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using System;
using System.Net;
namespace Tests
{
    class PricingBtnVefification : BaseTests
    {
        [Test]
        public void PricingPageTryFreeBtn1()
        {
            MainPage main = new MainPage(driver);
            Pricing pricing = new Pricing(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderPricing();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='uniblock_content_63']/div/div/a")));
            string link = pricing.GetTryFreeBtn1();
            string actual = link;
            string expected = basepage.urlHeaderFreeTrial;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the button");
                Assert.AreEqual(myHttpWebResponse.StatusCode, HttpStatusCode.OK, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void PricingPageTryFreeBtn2()
        {
            MainPage main = new MainPage(driver);
            Pricing pricing = new Pricing(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderPricing();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='uniblock_content_63']/div/div/a")));
            string link = pricing.GetTryFreeBtn2();
            string actual = link;
            string expected = basepage.urlHeaderFreeTrial;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the button");
                Assert.AreEqual(myHttpWebResponse.StatusCode, HttpStatusCode.OK, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void PricingPageTryFreeBtn3()
        {
            MainPage main = new MainPage(driver);
            Pricing pricing = new Pricing(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderPricing();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='uniblock_content_63']/div/div/a")));
            string link = pricing.GetTryFreeBtn3();
            string actual = link;
            string expected = basepage.urlHeaderFreeTrial;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the button");
                Assert.AreEqual(myHttpWebResponse.StatusCode, HttpStatusCode.OK, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void PricingPageTryFreeBtn4()
        {
            MainPage main = new MainPage(driver);
            Pricing pricing = new Pricing(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderPricing();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='uniblock_content_63']/div/div/a")));
            string link = pricing.GetTryFreeBtn4();
            string actual = link;
            string expected = basepage.urlHeaderFreeTrial;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the button");
                Assert.AreEqual(myHttpWebResponse.StatusCode, HttpStatusCode.OK, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void PricingPageFitingLink1()
        {
            MainPage main = new MainPage(driver);
            Pricing pricing = new Pricing(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderPricing();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='uniblock_content_63']/div/div/a")));
            string link = pricing.GetFitings1();
            string actual = link;
            string expected = basepage.urlFaq13;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(myHttpWebResponse.StatusCode, HttpStatusCode.OK, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void PricingPageFitingLink2()
        {
            MainPage main = new MainPage(driver);
            Pricing pricing = new Pricing(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderPricing();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='uniblock_content_63']/div/div/a")));
            string link = pricing.GetFitings2();
            string actual = link;
            string expected = basepage.urlFaq13;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(myHttpWebResponse.StatusCode, HttpStatusCode.OK, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void PricingPageFitingLink3()
        {
            MainPage main = new MainPage(driver);
            Pricing pricing = new Pricing(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderPricing();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='uniblock_content_63']/div/div/a")));
            string link = pricing.GetFitings3();
            string actual = link;
            string expected = basepage.urlFaq13;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(myHttpWebResponse.StatusCode, HttpStatusCode.OK, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void PricingPageContactUsLink()
        {
            MainPage main = new MainPage(driver);
            Pricing pricing = new Pricing(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderPricing();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='uniblock_content_63']/div/div/a")));
            string link = pricing.GetPricingContactUs();
            string actual = link;
            string expected = basepage.urlHeaderContact;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(myHttpWebResponse.StatusCode, HttpStatusCode.OK, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }
    }
}