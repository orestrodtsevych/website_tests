using OpenQA.Selenium;
using System;

namespace PageObjects
{
    public class BasePage
    {
        protected static IWebDriver driver;
        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public string accountEditResult = "Your account has been successfully updated";
        public string passwordChangeResult = "Password has been changed.";
        public string loginResult = "My Account";
        public string logoutResult = "Problem";

        public string email1 = "support@looksize.com";
        public string phone1 = "+1 (416) 848-4067";
        public string email2 = "sales@looksize.com";
        public string phone2 = "+1 (416) 848-4067";
        public string viber1 = "viber://chat/?number=%2B380963834754";
        public string skype1 = "skype:intelex1?chat";
        public string facebook1 = "https://m.me/taras.rodtsevych";
        public string linkedin1 = "https://www.linkedin.com/in/taras-rodtsevych/";
        public string whatsup1 = "https://wa.me/380963834754";
        public string viber2 = "viber://chat/?number=%2B380963834754";
        public string skype2 = "skype:intelex1?chat";
        public string facebook2 = "https://m.me/taras.rodtsevych";
        public string linkedin2 = "https://www.linkedin.com/in/taras-rodtsevych/";
        public string whatsup2 = "https://wa.me/380963834754";

        public string svitstylepage = "https://www.looksize.com/inspiration-samples?item=18";

        public string pricingQuoteResult = "Your message has been successfully sent";
        public string fitOnlineSearchResult = "Adidas";

        public string urlFreeTrialToFitOnline = "https://www.looksize.com/en/fit-online";
        public string urlFaq13 = "https://www.looksize.com/faq#13";

        public string urlDemoStoreImage = "https://www.looksize.com/UserFiles/Image/demo_shop.jpg.webp";

        public string urlDemoStore = "https://www.demo-store.looksize.com/";
        public string urlDemoStoreCatalog = "https://www.demo-store.looksize.com/for-woman-10cat/dresses--11cat";
        public string urlDemoStoreProduct = "https://www.demo-store.looksize.com/for-woman-10cat/dresses--11cat/black-halo-womens-conger-sheath-dress-426prd";

        public string urlPlayerSrc = "https://www.looksize.com//UserFiles/File/LookSizeVideo_en01_8.mp4";
        public string urlPlayerAlt = "How my size button works";

        public string urlHeaderHome = "https://www.looksize.com/";
        public string urlHeaderDemoStore = "https://www.looksize.com/demo-store";
        public string urlHeaderPricing = "https://www.looksize.com/pricing";
        public string urlHeaderFreeTrial = "https://www.looksize.com/free-trial";
        public string urlHeaderFitOnline = "https://www.looksize.com/fit-online";
        public string urlHeaderOurClients = "https://www.looksize.com/our-clients";
        public string urlHeaderContact = "https://www.looksize.com/contacts";

        public string urlFooterDemoStore = "https://www.looksize.com/demo-store";
        public string urlFooterFaq = "https://www.looksize.com/faq";
        public string urlFooterInstructions = "https://www.looksize.com/instructions";
        public string urlFooterTermsOfService = "https://www.looksize.com/terms-of-service";
        public string urlFooterSizeChartsRetailers = "https://www.looksize.com/size-charts";

        public string urlFooterHowTo = "https://www.looksize.com/body-measurements";
        public string urlFooterUserAgreement = "https://www.looksize.com/user-agreement";
        public string urlFooterPrivacyPolicy = "https://www.looksize.com/privacy-policy";
        public string urlFooterCookiePolicy = "https://www.looksize.com/cookie-policy";
        public string urlFooterFitOnline = "https://www.looksize.com/fit-online";

        public string urlFooterSizeChartsBrand = "https://www.looksize.com/by-brands-a-z";
        public string urlFooterAddMyBrand = "https://www.looksize.com/add-my-brand-chart";

        public string urlFooterPress = "https://www.looksize.com/press";
        public string urlFooterLinkedin = "https://www.linkedin.com/company/looksize";
        public string urlFooterFacebook = "https://www.facebook.com/LookSize-Global-105704778221731";
        public string urlFooterTwitter = "https://twitter.com/looksize_";
        public string urlFooterInstagram = "https://www.instagram.com/looksize/";
        public string urlFooterBlog = "https://www.looksize.com/blog";

        public string urlDetermineTheSize = "https://www.looksize.com/determine-size";
    }
}
