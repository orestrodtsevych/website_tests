using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using System;
using System.Net;
using System.Threading;

namespace Tests
{
    class PricingRequestAQuote : BaseTests
    {
        [Test]
        public void RequestAQuoteTest()
        {
            MainPage main = new MainPage(driver);
            Pricing pricing = new Pricing(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderPricing();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='uniblock_content_63']/div/div/a")));
            pricing.ClickPricingRequestAQuote();
            Thread.Sleep(3000);
            pricing.InputPricingRequestAQuoteName();
            pricing.InputPricingRequestAQuoteSurname();
            pricing.InputPricingRequestAQuoteEmail();
            pricing.InputPricingRequestAQuotePhone();
            pricing.InputPricingRequestAQuoteJob();
            pricing.InputPricingRequestAQuoteUrlStore();
            Thread.Sleep(1000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string title = (string)js.ExecuteScript("$('#security_code').removeAttr('pattern').val('orko')");
            pricing.ClickPricingRequestAQuoteSubmit();
            Thread.Sleep(1000);
            string result = pricing.GetPricingRequestAQuoteResult();
            Console.WriteLine(result);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(basepage.pricingQuoteResult, result, "Error in form");
            });
        }
    }
}
