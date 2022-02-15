using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects
{
    public class DemoStore : BasePage
    {
        public DemoStore(IWebDriver driver) : base(driver)
        {

        }

        //Links
        private IWebElement DemoStoreLink => driver.FindElement(By.XPath("//*[@id='id_main_content']/p[1]/a[1]"));
        private IWebElement MySizeButtonLink => driver.FindElement(By.XPath("//*[@id='id_main_content']/p[1]/a[2]"));
        private IWebElement SizingWidgetLink => driver.FindElement(By.XPath("//*[@id='id_main_content']/p[1]/a[3]"));
        public void ClickDemoStoreLink() => DemoStoreLink.Click();
        public void ClickMySizeButtonLink() => MySizeButtonLink.Click();
        public void ClickSizingWidgetLink() => SizingWidgetLink.Click();
        public string GetDemoStoreLink() => DemoStoreLink.GetAttribute("href");
        public string GetMySizeButtonLink() => MySizeButtonLink.GetAttribute("href");
        public string GetSizingWidgetLink() => SizingWidgetLink.GetAttribute("href");


        //Buttons
        private IWebElement MySizeButtonBtn => driver.FindElement(By.XPath("//*[@id='id_main_content']/p[2]/a[1]"));
        private IWebElement SizingWidgetBtn => driver.FindElement(By.XPath("//*[@id='id_main_content']/p[2]/a[2]"));
        public void ClickMySizeButtonBtn() => MySizeButtonBtn.Click();
        public void ClickSizingWidgetBtn() => SizingWidgetBtn.Click();
        public string GetMySizeButtonBtn() => MySizeButtonLink.GetAttribute("href");
        public string GetSizingWidgetBtn() => SizingWidgetLink.GetAttribute("href");

        //Image
        private IWebElement DemoStoreImage => driver.FindElement(By.XPath("//*[@id='id_main_content']/p[3]/a/img"));
        public void ClickDemoStoreImage() => DemoStoreImage.Click();
        public string GetDemoStoreImage() => DemoStoreImage.GetAttribute("src");
    }
}
