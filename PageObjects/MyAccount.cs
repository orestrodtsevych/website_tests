using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;

namespace PageObjects
{
    public class MyAccount : BasePage
    {
        public MyAccount(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement ChangePasswordBtn => driver.FindElement(By.XPath("//*[@id='id_main_content']/div/div[3]/a"));
        public void ClickChangePasswordBtn() => ChangePasswordBtn.Click();

        public IWebElement Password1 => driver.FindElement(By.XPath("//*[@id='pass']"));
        public void InputPassword1() => Password1.SendKeys("Orestnazar2");

        public IWebElement Password2 => driver.FindElement(By.XPath("//*[@id='confirm_pass']"));
        public void InputPassword2() => Password2.SendKeys("Orestnazar2");

        public IWebElement ChangeBtn => driver.FindElement(By.XPath("//*[@id='main_form']/div[1]/div[3]/button"));
        public void ClickChangeBtn() => ChangeBtn.Click();

        private IWebElement ChangePasswordResult => driver.FindElement(By.XPath("//*[@id='content_message']/div"));
        public string GetChangePasswordResult() => ChangePasswordResult.Text;

        public IWebElement MyAccountBtn => driver.FindElement(By.XPath("//*[@id='id_main_content']/div/div[2]"));
        public void ClickMyAccountBtn() => MyAccountBtn.Click();

        public IWebElement EditMyAccountBtn => driver.FindElement(By.XPath("//*[@id='id_main_content']/button"));
        public void ClickEditMyAccountBtn() => EditMyAccountBtn.Click();

        public IWebElement UpdateBtn => driver.FindElement(By.XPath("//*[@id='btn_submit']"));
        public void ClickUpdateBtn() => UpdateBtn.Click();

        private IWebElement UpdateResult => driver.FindElement(By.XPath("//*[@id='content_message']/div"));
        public string GetUpdateResult() => UpdateResult.Text;

        private IWebElement DetermineTheSizeBtn => driver.FindElement(By.XPath("//*[@id='id_main_content']/div/div[1]/a"));
        public string GetDetermineTheSizeBtn() => DetermineTheSizeBtn.GetAttribute("href");

        public IWebElement ChangePasswordBtnLeft => driver.FindElement(By.XPath("//*[@id='profile_left']/li[3]/a"));
        public void ClickChangePasswordBtnLeft() => ChangePasswordBtnLeft.Click();

        private IWebElement DetermineTheSizeBtnLeft => driver.FindElement(By.XPath("//*[@id='profile_left]/li[1]/a"));
        public string GetDetermineTheSizeBtnLeft() => DetermineTheSizeBtnLeft.GetAttribute("href");

        public IWebElement MyAccountBtnLeft => driver.FindElement(By.XPath("//*[@id='profile_left']/li[2]/a"));
        public void ClickMyAccountBtnLeft() => MyAccountBtnLeft.Click();
    }
}
