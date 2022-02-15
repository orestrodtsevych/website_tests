using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using System;
using System.Net;
using System.Threading;

namespace Tests
{
    class FitOnlineTests : BaseTests
    {
        //[Test]
        //public void FitOnlineBrandTest()
        //{
        //    MainPage main = new MainPage(driver);
        //    FitOnline fitonline = new FitOnline(driver);
        //    BasePage basepage = new BasePage(driver);
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //    IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='main_video']")));
        //    main.ClickHeaderFitOnline();
        //    IWebElement SearchResult2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='demo_widjet_img']")));
        //    fitonline.InsertbrandField();
        //    Thread.Sleep(3000);
        //    IWebElement SearchResult3 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='search_brand_rst']/div/div")));
        //    string GotSearchResult = fitonline.GetBrandResult();
        //    fitonline.ClickBrandResult();
        //    IWebElement SearchResult4 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='box_category']/option[5]")));
        //    //IWebElement SearchResult5 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='LS_bt_close_bottom']")));
        //    //string widgetOpen = fitonline.GetWidgetOpen();
        //    //Console.WriteLine(GotSearchResult+"\n"+  "\n" + widgetOpen);
        //    //Assert.Multiple(() =>
        //    //{
        //    //Assert.AreEqual(actual, expected, "Wrong URL in the Link");
        //    //Assert.AreEqual(myHttpWebResponse.StatusCode, HttpStatusCode.OK, link + " code is " + myHttpWebResponse.StatusCode);
        //    //});
        //}
    }
}
