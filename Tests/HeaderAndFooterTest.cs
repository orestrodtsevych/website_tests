using NUnit.Framework;
using PageObjects;
using System;
using System.Net;
namespace Tests
{
    class HeaderAndFooterTest : BaseTests
    {
        [Test]
        public void HeaderHomeOpen()
        {
            MainPage main = new MainPage(driver);
            string link = main.GetHeaderDemoStore();
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void HeaderDemoStoreOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetHeaderDemoStore();
            string actual = link;
            string expected = basepage.urlHeaderDemoStore;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void HeaderPricingOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetHeaderPricing();
            string actual = link;
            string expected = basepage.urlHeaderPricing;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void HeaderFreeTrialOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetHeaderFreeTrial();
            string actual = link;
            string expected = basepage.urlHeaderFreeTrial;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void HeaderFitOnlineOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetHeaderFitOnline();
            string actual = link;
            string expected = basepage.urlHeaderFitOnline;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void HeaderOurClientsOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetHeaderOurClients();
            string actual = link;
            string expected = basepage.urlHeaderOurClients;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void HeaderContactOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetHeaderContact();
            string actual = link;
            string expected = basepage.urlHeaderContact;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void FooterDemoStoreOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterDemoStore();
            string actual = link;
            string expected = basepage.urlFooterDemoStore;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void FooterFaqOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterFaq();
            string actual = link;
            string expected = basepage.urlFooterFaq;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void FooterInstructionOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterInstruction();
            string actual = link;
            string expected = basepage.urlFooterInstructions;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void FooterTermsOfServiceOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterTermsOfService();
            string actual = link;
            string expected = basepage.urlFooterTermsOfService;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void FooterSizeChartsRetailersOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterSizeChartsRetailers();
            string actual = link;
            string expected = basepage.urlFooterSizeChartsRetailers;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void FooterHowToOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterHowTo();
            string actual = link;
            string expected = basepage.urlFooterHowTo;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void FooterUserAgreementOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterUserAgreement();
            string actual = link;
            string expected = basepage.urlFooterUserAgreement;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void FooterPrivacyPolicyOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterPrivacyPolicy();
            string actual = link;
            string expected = basepage.urlFooterPrivacyPolicy;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void FooterCookiesPolicyOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterCookiePolicy();
            string actual = link;
            string expected = basepage.urlFooterCookiePolicy;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void FooterFitOnlineOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterFitOnline();
            string actual = link;
            string expected = basepage.urlFooterFitOnline;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void FooterSizeChartsBrandsOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterSizeChartsBrands();
            string actual = link;
            string expected = basepage.urlFooterSizeChartsBrand;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void FooterAddMyBrandOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterAddMyBrand();
            string actual = link;
            string expected = basepage.urlFooterAddMyBrand;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void FooterPressOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterPress();
            string actual = link;
            string expected = basepage.urlFooterPress;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void FooterLinkedinOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterLinkedin();
            string actual = link;
            string expected = basepage.urlFooterLinkedin;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
            });
        }

        [Test]
        public void FooterFacebookOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterFacebook();
            string actual = link;
            string expected = basepage.urlFooterFacebook;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        //[Test]
        //public void FooterTwitterOpen()
        //{
        //    MainPage main = new MainPage(driver);
        //    BasePage basepage = new BasePage(driver);
        //    string link = main.GetFooterTwitter();
        //    string actual = link;
        //    string expected = basepage.urlFooterTwitter;
        //    HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
        //    HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
        //    Assert.Multiple(() =>
        //    {
        //        Assert.AreEqual(actual, expected, "Wrong URL in the link");
        //        Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode, link + " code is " + myHttpWebResponse.StatusCode);
        //    });
        //}

        [Test]
        public void FooterInstagramOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterInstagram();
            string actual = link;
            string expected = basepage.urlFooterInstagram;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode,  link + " code is " + myHttpWebResponse.StatusCode);
            });
        }

        [Test]
        public void FooterBlogOpen()
        {
            MainPage main = new MainPage(driver);
            BasePage basepage = new BasePage(driver);
            string link = main.GetFooterBlog();
            string actual = link;
            string expected = basepage.urlFooterBlog;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(actual, expected, "Wrong URL in the link");
                Assert.AreEqual(HttpStatusCode.OK, myHttpWebResponse.StatusCode, link + " code is " + myHttpWebResponse.StatusCode);
            });
        }
    }
}
