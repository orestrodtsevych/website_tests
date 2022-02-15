using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects
{
    public class Pricing : BasePage
    {
        public Pricing(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement TryFreeBtn1 => driver.FindElement(By.XPath("//*[@id='block_pricing_plan']/div/div/div[1]/div[4]/a"));
        public void ClickTryFreeBtn1() => TryFreeBtn1.Click();
        public string GetTryFreeBtn1() => TryFreeBtn1.GetAttribute("href");

        private IWebElement TryFreeBtn2 => driver.FindElement(By.XPath("//*[@id='block_pricing_plan']/div/div/div[2]/div[4]/a"));
        public void ClickTryFreeBtn2() => TryFreeBtn2.Click();
        public string GetTryFreeBtn2() => TryFreeBtn2.GetAttribute("href");

        private IWebElement TryFreeBtn3 => driver.FindElement(By.XPath("//*[@id='block_pricing_plan']/div/div/div[3]/div[4]/a"));
        public void ClickTryFreeBtn3() => TryFreeBtn3.Click();
        public string GetTryFreeBtn3() => TryFreeBtn3.GetAttribute("href");

        private IWebElement TryFreeBtn4 => driver.FindElement(By.XPath("//*[@id='uniblock_content_63']/div/div/a"));
        public void ClickTryFreeBtn4() => TryFreeBtn4.Click();
        public string GetTryFreeBtn4() => TryFreeBtn4.GetAttribute("href");

        private IWebElement Fitings1 => driver.FindElement(By.XPath("//*[@id='block_pricing_plan']/div/div/div[1]/div[3]/a"));
        public void ClickFitings1() => Fitings1.Click();
        public string GetFitings1() => Fitings1.GetAttribute("href");

        private IWebElement Fitings2 => driver.FindElement(By.XPath("//*[@id='block_pricing_plan']/div/div/div[2]/div[3]/a"));
        public void ClickFitings2() => Fitings2.Click();
        public string GetFitings2() => Fitings2.GetAttribute("href");

        private IWebElement Fitings3 => driver.FindElement(By.XPath("//*[@id='block_pricing_plan']/div/div/div[3]/div[3]/a"));
        public void ClickFitings3() => Fitings3.Click();
        public string GetFitings3() => Fitings3.GetAttribute("href");

        private IWebElement PricingContactUs => driver.FindElement(By.XPath("//*[@id='uniblock_content_63']/div/div/p/a"));
        public void ClickPricingContactUs() => PricingContactUs.Click();
        public string GetPricingContactUs() => PricingContactUs.GetAttribute("href");

        private IWebElement PricingRequestAQuote => driver.FindElement(By.XPath("//*[@id='btn_request_quote']"));
        public void ClickPricingRequestAQuote() => PricingRequestAQuote.Click();
        public string GetPricingRequestAQuote() => PricingRequestAQuote.GetAttribute("href");

        private IWebElement PricingRequestAQuoteName => driver.FindElement(By.XPath("//*[@id='first_name']"));
        private IWebElement PricingRequestAQuoteSurname => driver.FindElement(By.XPath("//*[@id='last_name']"));
        private IWebElement PricingRequestAQuoteEmail => driver.FindElement(By.XPath("//*[@id='email']"));
        private IWebElement PricingRequestAQuotePhone => driver.FindElement(By.XPath("//*[@id='phone']"));
        private IWebElement PricingRequestAQuoteJob => driver.FindElement(By.XPath("//*[@id='job_title']"));
        private IWebElement PricingRequestAQuoteUrlStore => driver.FindElement(By.XPath("//*[@id='site']"));
        public void InputPricingRequestAQuoteName() => PricingRequestAQuoteName.SendKeys("test");
        public void InputPricingRequestAQuoteSurname() => PricingRequestAQuoteSurname.SendKeys("test");
        public void InputPricingRequestAQuoteEmail() => PricingRequestAQuoteEmail.SendKeys("test@test.com");
        public void InputPricingRequestAQuotePhone() => PricingRequestAQuotePhone.SendKeys("380961234567");
        public void InputPricingRequestAQuoteJob() => PricingRequestAQuoteJob.SendKeys("test job");
        public void InputPricingRequestAQuoteUrlStore() => PricingRequestAQuoteUrlStore.SendKeys("test.com.ua");

        private IWebElement PricingRequestAQuoteSubmit => driver.FindElement(By.XPath("//*[@id='request_quote_div']/div[2]/div/div[2]/div[2]/button"));
        public void ClickPricingRequestAQuoteSubmit() => PricingRequestAQuoteSubmit.Click();

        private IWebElement PricingRequestAQuoteResult => driver.FindElement(By.XPath("//*[@id='request_quote_div']/div"));
        public string GetPricingRequestAQuoteResult() => PricingRequestAQuoteResult.Text;
    }
}
