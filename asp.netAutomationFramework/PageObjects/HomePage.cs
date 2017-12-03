using OpenQA.Selenium;
using asp.netAutomationFramework.WebDriverAPIWrapper;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace asp.netAutomationFramework.PageObjects
{
    class HomePage : BasePage
    {
        private IWebDriver driver;
        private By downloadVS = By.XPath("//a[@data-product=\"Visual Studio\"]");
        private string basePageURL = "http://asp.net";
        private string homePageTitle = "ASP.NET | The ASP.NET Site";

        public HomePage(IWebDriver driver):base(driver)
        {
            this.driver = driver;
        }

        public HomePage OpenHomePage()
        {
            OpenHomePageByURL();
            return new HomePage(driver);
        }

        public void VerifyHomePageTitle()
        {
            VerifyTitle(homePageTitle);
        }

       
    }
}
