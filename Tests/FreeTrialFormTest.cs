using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using System;
using System.Net;
using System.Threading;

namespace Tests
{
    class FreeTrialFormTest : BaseTests
    {
        [Test]
        public void TryVirtualFeetingRoomforFree()
        {
            MainPage main = new MainPage(driver);
            FreeTrial freeTrial = new FreeTrial(driver);
            BasePage basepage = new BasePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
            main.ClickHeaderFreeTrial();
            IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='id_main_content']/div/div/div/div[1]/button")));
            freeTrial.ClickFreeTrialForm();
            Thread.Sleep(3000);
            freeTrial.InputFreeTrialFormName();
            freeTrial.InputFreeTrialFormEmail();
            freeTrial.InputFreeTrialFormPhone();
            freeTrial.InputFreeTrialFormUrlStore();
            Thread.Sleep(1000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string title = (string)js.ExecuteScript("$('#security_code').removeAttr('pattern').val('orko')");
            freeTrial.ClickFreeTrialFormSubmit();
            Thread.Sleep(1000);
            string result = freeTrial.ClickFreeTrialFormResult();
            Console.WriteLine(result);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(basepage.pricingQuoteResult, result, "Error in form");
            });
        }
    }
}
