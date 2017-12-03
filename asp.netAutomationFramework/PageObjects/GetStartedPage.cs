using OpenQA.Selenium;
using NUnit.Framework;
namespace asp.netAutomationFramework.PageObjects
{
    class GetStartedPage : BasePage
    {
        
        private IWebDriver driver;
        public GetStartedPage(IWebDriver driver):base(driver)
        {
           this.driver = driver;
        }

        //Declare Home page locators 
        By getStartedLink = By.XPath("//a[text()=\"Get Started with ASP.NET\"]");
        By learnMoreLink = By.XPath("//a[text()=\"Learn more\"]");
        //Declare Home page methods

        public void VerifyTitle()
        {
            Assert.AreEqual(driver.Title, "Get Started with ASP.NET | The ASP.NET Site");
        }

    }
}
