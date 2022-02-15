using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using System;
using System.Net;
using System.Threading;
namespace Tests
{
    class FreeTrialBtnVerification : BaseTests
    {
        [Test]
        public void FreeTrialFitOnlineBtn()
        {
            MainPage main = new MainPage(driver);
            FreeTrial freetrial = new FreeTrial(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderFreeTrial();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/div/div/div/div[2]/a")));
            string link = freetrial.GetFitOnlineBtn();
            string actual = link;
            string expected = basepage.urlFreeTrialToFitOnline;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected, actual, "Wrong URL in the Link");
                Assert.AreEqual(myHttpWebResponse.StatusCode, HttpStatusCode.OK, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }
    }
}
