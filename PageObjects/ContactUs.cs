using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;

namespace PageObjects
{
    public class ContactUs : BasePage
    {
        public ContactUs(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement Email1 => driver.FindElement(By.XPath("//*[@id='id_main_content']/div[1]/div[2]/a"));
        public string Email1Text() => Email1.Text;

        public IWebElement Email2 => driver.FindElement(By.XPath("//*[@id='id_main_content']/div[2]/div[2]/a"));
        public string Email2Text() => Email2.Text;

        public IWebElement Phone1 => driver.FindElement(By.XPath("//*[@id='id_main_content']/div[1]/div[3]/a"));
        public string Phone1Text() => Phone1.Text;

        public IWebElement Phone2 => driver.FindElement(By.XPath("//*[@id='id_main_content']/div[2]/div[3]/a"));
        public string Phone2Text() => Phone2.Text;

        public IWebElement Viber1 => driver.FindElement(By.XPath("//*[@id='id_main_content']/div[1]/a[1]"));
        public string Viber1Href() => Viber1.GetAttribute("href");

        public IWebElement Viber2 => driver.FindElement(By.XPath("//*[@id='id_main_content']/div[2]/a[1]"));
        public string Viber2Href() => Viber2.GetAttribute("href");

        public IWebElement Skype1 => driver.FindElement(By.XPath("//*[@id='id_main_content']/div[1]/a[2]"));
        public string Skype1Href() => Skype1.GetAttribute("href");

        public IWebElement Skype2 => driver.FindElement(By.XPath("//*[@id='id_main_content']/div[2]/a[2]"));
        public string Skype2Href() => Skype2.GetAttribute("href");

        public IWebElement Facebook1 => driver.FindElement(By.XPath("//*[@id='id_main_content']/div[1]/a[3]"));
        public string Facebook1Href() => Facebook1.GetAttribute("href");

        public IWebElement Facebook2 => driver.FindElement(By.XPath("//*[@id='id_main_content']/div[2]/a[3]"));
        public string Facebook2Href() => Facebook2.GetAttribute("href");

        public IWebElement Linkedin1 => driver.FindElement(By.XPath("//*[@id='id_main_content']/div[1]/a[4]"));
        public string Linkedin1Href() => Linkedin1.GetAttribute("href");

        public IWebElement Linkedin2 => driver.FindElement(By.XPath("//*[@id='id_main_content']/div[2]/a[4]"));
        public string Linkedin2Href() => Linkedin2.GetAttribute("href");

        public IWebElement WhatsUp1 => driver.FindElement(By.XPath("//*[@id='id_main_content']/div[1]/a[5]"));
        public string WhatsUp1Href() => WhatsUp1.GetAttribute("href");

        public IWebElement WhatsUp2 => driver.FindElement(By.XPath("//*[@id='id_main_content']/div[2]/a[5]"));
        public string WhatsUp2Href() => WhatsUp2.GetAttribute("href");
    }
}
