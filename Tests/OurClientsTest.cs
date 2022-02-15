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
    class OurClientsTest : BaseTests
    {
        [Test]
        public void FitOnlineBrandTest()
        {
            MainPage main = new MainPage(driver);
            OurClients ourclients = new OurClients(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderOurClients();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='uniblock_content_65']/div/div/div/div/a")));
            string link = ourclients.GetCaseStudyBtn();
            string actual = link;
            string expected = basepage.svitstylepage;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the button");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }
    }
}
