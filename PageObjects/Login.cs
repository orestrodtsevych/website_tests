using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;

namespace PageObjects
{
    public class Login : BasePage
    {
        public Login(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement Email => driver.FindElement(By.XPath("//*[@id='email']"));
        public void InputEmail() => Email.SendKeys("gwggww@gmail.com");

        public IWebElement Password => driver.FindElement(By.XPath("//*[@id='box_pass']/div/input[1]"));
        public void InputPassword() => Password.SendKeys("Orestnazar2");

        public IWebElement LoginBtn => driver.FindElement(By.XPath("//*[@id='sign']"));
        public void ClickLoginBtn() => LoginBtn.Click();

        private IWebElement LoginResult => driver.FindElement(By.XPath("//*[@id='id_main_content']/h1"));
        public string GetLoginResult() => LoginResult.Text;

        public IWebElement LogoutBtn => driver.FindElement(By.XPath("//*[@id='id_main_content']/div/div[5]/a"));
        public void ClickLogoutBtn() => LogoutBtn.Click();

        private IWebElement LogoutResult => driver.FindElement(By.XPath("//*[@id='uniblock_content_86']/div/div/div/div[1]/div[1]"));
        public string GetLogoutResult() => LogoutResult.Text;
    }
}
