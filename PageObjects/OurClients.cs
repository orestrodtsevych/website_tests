using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;

namespace PageObjects
{
    public class OurClients : BasePage
    {
        public OurClients(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement CaseStudyBtn => driver.FindElement(By.XPath("//*[@id='uniblock_content_65']/div/div/div/div/a"));
        public string GetCaseStudyBtn() => CaseStudyBtn.GetAttribute("href");
        public void ClickCaseStudyBtn() => CaseStudyBtn.Click();
    }
}
