using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver)
        {

        }

        //Header
        private IWebElement headerDemoStore => driver.FindElement(By.XPath("//*[@id='top_menu']/ul/li[2]/a"));
        private IWebElement headerPricing => driver.FindElement(By.XPath("//*[@id='top_menu']/ul/li[3]/a"));
        private IWebElement headerFreeTrial => driver.FindElement(By.XPath("//*[@id='top_menu']/ul/li[4]/a"));
        private IWebElement headerFitOnline => driver.FindElement(By.XPath("//*[@id='top_menu']/ul/li[5]/a"));
        private IWebElement headerOurClients => driver.FindElement(By.XPath("//*[@id='top_menu']/ul/li[6]/a"));
        private IWebElement headerContact => driver.FindElement(By.XPath("//*[@id='top_menu']/ul/li[7]/a"));


        public void ClickHeaderDemoStore() => headerDemoStore.Click();
        public void ClickHeaderPricing() => headerPricing.Click();
        public void ClickHeaderFreeTrial() => headerFreeTrial.Click();
        public void ClickHeaderFitOnline() => headerFitOnline.Click();
        public void ClickHeaderOurClients() => headerOurClients.Click();
        public void ClickHeaderContact() => headerContact.Click();


        public string GetHeaderDemoStore() => headerDemoStore.GetAttribute("href");
        public string GetHeaderPricing() => headerPricing.GetAttribute("href");
        public string GetHeaderFreeTrial() => headerFreeTrial.GetAttribute("href");
        public string GetHeaderFitOnline() => headerFitOnline.GetAttribute("href");
        public string GetHeaderOurClients() => headerOurClients.GetAttribute("href");
        public string GetHeaderContact() => headerContact.GetAttribute("href");


        //Footer
        private IWebElement footerDemoStore => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[1]/ul/li[2]/a"));
        private IWebElement footerFaq => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[1]/ul/li[3]/a"));
        private IWebElement footerInstruction => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[1]/ul/li[4]/a"));
        private IWebElement footerTermsOfService => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[1]/ul/li[5]/a"));
        private IWebElement footerSizeChartsRetailers => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[1]/ul/li[6]/a"));
        private IWebElement footerHowTo => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[2]/ul/li[2]/a"));
        private IWebElement footerUserAgreement => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[2]/ul/li[3]/a"));
        private IWebElement footerPrivacyPolicy => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[2]/ul/li[4]/a"));
        private IWebElement footerCookiePolicy => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[2]/ul/li[5]/a"));
        private IWebElement footerFitOnline => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[2]/ul/li[6]/a"));
        private IWebElement footerSizeChartsBrands => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[3]/ul/li[2]/a"));
        private IWebElement footerAddMyBrand => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[3]/ul/li[3]/a"));
        private IWebElement footerPress => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[4]/ul/li[2]/a"));
        private IWebElement footerLinkedin => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[4]/ul/li[3]/a"));
        private IWebElement footerFacebook => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[4]/ul/li[4]/a"));
        private IWebElement footerTwitter => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[4]/ul/li[5]/a"));
        private IWebElement footerInstagram => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[4]/ul/li[5]/a"));
        private IWebElement footerBlog => driver.FindElement(By.XPath("//*[@id='footer']/div/div/div/div/div[4]/ul/li[6]/a"));


        public void ClickFooterDemoStore() => footerDemoStore.Click();
        public void ClickFooterFaq() => footerFaq.Click();
        public void ClickFooterInstruction() => footerInstruction.Click();
        public void ClickFooterTermsOfService() => footerTermsOfService.Click();
        public void ClickFooterSizeChartsRetailers() => footerSizeChartsRetailers.Click();
        public void ClickFooterHowTo() => footerHowTo.Click();
        public void ClickFooterUserAgreement() => footerUserAgreement.Click();
        public void ClickFooterPrivacyPolicy() => footerPrivacyPolicy.Click();
        public void ClickFooterCookiePolicy() => footerCookiePolicy.Click();
        public void ClickFooterFitOnline() => footerFitOnline.Click();
        public void ClickFooterSizeChartsBrands() => footerSizeChartsBrands.Click();
        public void ClickFooterAddMyBrand() => footerAddMyBrand.Click();
        public void ClickFooterPress() => footerPress.Click();
        public void ClickFooterLinkedin() => footerLinkedin.Click();
        public void ClickFooterFacebook() => footerFacebook.Click();
        public void ClickFooterTwitter() => footerTwitter.Click();
        public void ClickFooterInstagram() => footerInstagram.Click();
        public void ClickFooterBlog() => footerBlog.Click();


        public string GetFooterDemoStore() => footerDemoStore.GetAttribute("href");
        public string GetFooterFaq() => footerFaq.GetAttribute("href");
        public string GetFooterInstruction() => footerInstruction.GetAttribute("href");
        public string GetFooterTermsOfService() => footerTermsOfService.GetAttribute("href");
        public string GetFooterSizeChartsRetailers() => footerSizeChartsRetailers.GetAttribute("href");
        public string GetFooterHowTo() => footerHowTo.GetAttribute("href");
        public string GetFooterUserAgreement() => footerUserAgreement.GetAttribute("href");
        public string GetFooterPrivacyPolicy() => footerPrivacyPolicy.GetAttribute("href");
        public string GetFooterCookiePolicy() => footerCookiePolicy.GetAttribute("href");
        public string GetFooterFitOnline() => footerFitOnline.GetAttribute("href");
        public string GetFooterSizeChartsBrands() => footerSizeChartsBrands.GetAttribute("href");
        public string GetFooterAddMyBrand() => footerAddMyBrand.GetAttribute("href");
        public string GetFooterPress() => footerPress.GetAttribute("href");
        public string GetFooterLinkedin() => footerLinkedin.GetAttribute("href");
        public string GetFooterFacebook() => footerFacebook.GetAttribute("href");
        public string GetFooterTwitter() => footerTwitter.GetAttribute("href");
        public string GetFooterInstagram() => footerInstagram.GetAttribute("href");
        public string GetFooterBlog() => footerBlog.GetAttribute("href");

        //Try free buttons
        private IWebElement btnTryFree1 => driver.FindElement(By.XPath("//*[@id='id_main_content']/div/h1/a"));
        private IWebElement btnTryFree2 => driver.FindElement(By.XPath("//*[@id='uniblock_content_56']/div/div/div/div/div[1]/div[3]/a"));
        private IWebElement btnTryFree3 => driver.FindElement(By.XPath("//*[@id='uniblock_content_63']/div/div/a"));

        public void ClickBtnTryFree1() => btnTryFree1.Click();
        public void ClickBtnTryFree2() => btnTryFree2.Click();
        public void ClickBtnTryFree3() => btnTryFree3.Click();
        public string GetBtnTryFree1() => btnTryFree1.GetAttribute("href");
        public string GetBtnTryFree2() => btnTryFree2.GetAttribute("href");
        public string GetBtnTryFree3() => btnTryFree3.GetAttribute("href");

        private IWebElement btnContactUs => driver.FindElement(By.XPath("//*[@id='uniblock_content_63']/div/div/p/a"));
        public void ClickLinkContactUs() => btnContactUs.Click();
        public string GetLinkContactUs() => btnContactUs.GetAttribute("href");

        public IWebElement btnPlayer => driver.FindElement(By.XPath("//*[@id='main_video']"));
        private IWebElement btnPlayerSrc => driver.FindElement(By.XPath("//*[@id='inline_video']/div/video/source"));
        private IWebElement btnPlayerAlt => driver.FindElement(By.XPath("//*[@id='inline_video']/div/video/img"));
        public void ClickBtnPlayer() => btnPlayer.Click();
        public string GetBtnPlayerSrc() => btnPlayerSrc.GetAttribute("src");
        public string GetbtnPlayerAlt() => btnPlayerAlt.GetAttribute("alt");

        //Login
        private IWebElement btnLogin => driver.FindElement(By.XPath("//*[@id='header_menu']/div/div[1]/a"));
        public void ClickBtnLogin() => btnLogin.Click();
    }
}
