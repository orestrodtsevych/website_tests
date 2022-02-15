using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;

namespace PageObjects
{
    public class FitOnline : BasePage
    {
        public FitOnline(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement brandField => driver.FindElement(By.XPath("//*[@id='brand']"));
        public void InsertbrandField() => brandField.SendKeys("Adidas");

        public IWebElement brandResult => driver.FindElement(By.XPath("/html/body/main/div/div/div/div/div[1]/div[4]/div/div/div/div/b"));
        public string GetBrandResult() => brandResult.Text;
        public void ClickBrandResult() => brandResult.Click();

        public IWebElement categoryResult => driver.FindElement(By.CssSelector("option[value='179']"));
        public string GetCategoryResultt() => categoryResult.Text;
        public void ClickCategoryResult() => categoryResult.Click();


        public IWebElement WidgetOpen => driver.FindElement(By.XPath("//*[@id='LS_bt_close_bottom']"));
        public string GetWidgetOpen() => WidgetOpen.Text;
    }
}
