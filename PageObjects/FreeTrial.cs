using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects
{
    public class FreeTrial : BasePage
    {
        public FreeTrial(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement FitOnlineBtn => driver.FindElement(By.XPath("//*[@id='id_main_content']/div/div/div/div[2]/a"));
        public void ClickFitOnlineBtn() => FitOnlineBtn.Click();
        public string GetFitOnlineBtn() => FitOnlineBtn.GetAttribute("href");

        public IWebElement FreeTrialForm => driver.FindElement(By.XPath("//*[@id='id_main_content']/div/div/div/div[1]/button"));
        public void ClickFreeTrialForm() => FreeTrialForm.Click();

        private IWebElement FreeTrialFormName => driver.FindElement(By.XPath("//*[@id='first_name']"));
        private IWebElement FreeTrialFormEmail => driver.FindElement(By.XPath("//*[@id='email']"));
        private IWebElement FreeTrialFormPhone => driver.FindElement(By.XPath("//*[@id='phone']"));
        private IWebElement FreeTrialFormUrlStore => driver.FindElement(By.XPath("//*[@id='site']"));
        public void InputFreeTrialFormName() => FreeTrialFormName.SendKeys("test");
        public void InputFreeTrialFormEmail() => FreeTrialFormEmail.SendKeys("test@test.com");
        public void InputFreeTrialFormPhone() => FreeTrialFormPhone.SendKeys("380961234567");
        public void InputFreeTrialFormUrlStore() => FreeTrialFormUrlStore.SendKeys("test.com.ua");

        public IWebElement FreeTrialFormSubmit => driver.FindElement(By.XPath("//*[@id='frm_request_try_free_div']/div[2]/div/div[2]/div[2]/button"));
        public void ClickFreeTrialFormSubmit() => FreeTrialFormSubmit.Click();

        public IWebElement FreeTrialFormResult => driver.FindElement(By.XPath("//*[@id='frm_request_try_free_div']/div"));
        public string ClickFreeTrialFormResult() => FreeTrialFormResult.Text;
    }
}
