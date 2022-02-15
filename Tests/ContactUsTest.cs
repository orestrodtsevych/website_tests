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
    class ContactUsTest : BaseTests
    {
        [Test]
        public void FitOnlineBrandTest()
        {
            MainPage main = new MainPage(driver);
            ContactUs contactus = new ContactUs(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderContact();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/div[1]/a[5]/i")));
            string email1 = contactus.Email1Text();
            string email2 = contactus.Email2Text();
            string phone1 = contactus.Phone1Text();
            string phone2 = contactus.Phone2Text();
            string viber1 = contactus.Viber1Href();
            string viber2 = contactus.Viber2Href();
            string skype1 = contactus.Skype1Href();
            string skype2 = contactus.Skype2Href();
            string facebook1 = contactus.Facebook1Href();
            string facebook2 = contactus.Facebook2Href();
            string Linkedin1 = contactus.Linkedin1Href();
            string Linkedin2 = contactus.Linkedin2Href();
            string WhatsUp1 = contactus.WhatsUp1Href();
            string WhatsUp2 = contactus.WhatsUp2Href();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(email1, basepage.email1, "Wrong URL");
                Assert.AreEqual(email2, basepage.email2, "Wrong URL");
                Assert.AreEqual(phone1, basepage.phone1, "Wrong URL");
                Assert.AreEqual(phone2, basepage.phone2, "Wrong URL");
                Assert.AreEqual(viber1, basepage.viber1, "Wrong URL");
                Assert.AreEqual(viber2, basepage.viber2, "Wrong URL");
                Assert.AreEqual(skype1, basepage.skype1, "Wrong URL");
                Assert.AreEqual(skype2, basepage.skype2, "Wrong URL");
                Assert.AreEqual(facebook1, basepage.facebook1, "Wrong URL");
                Assert.AreEqual(facebook2, basepage.facebook2, "Wrong URL");
                Assert.AreEqual(Linkedin1, basepage.linkedin1, "Wrong URL");
                Assert.AreEqual(Linkedin2, basepage.linkedin2, "Wrong URL");
                Assert.AreEqual(WhatsUp1, basepage.whatsup1, "Wrong URL");
                Assert.AreEqual(WhatsUp2, basepage.whatsup2, "Wrong URL");
            });
        }
    }
}
