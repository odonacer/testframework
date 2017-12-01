using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using asp.netAutomationFramework.PageObjects;
using asp.netAutomationFramework.WebDriverAPIWrapper;

namespace asp.netAutomationFramework
{
    public class Class1
    {
        
        WebDriverAPI baseAPI = new WebDriverAPI();
        private readonly string url = "http://asp.net";
        HomePage homePage = new HomePage();

        [SetUp]
        public void SetUp()
        {
            baseAPI.StartChromeWebBrowser();
             
            

        }

        [Test]
        public void GoToHomePage()
        {
            homePage.OpenHomePage();
            //baseAPI.NavigateByURL(url);
        }
    }
}
