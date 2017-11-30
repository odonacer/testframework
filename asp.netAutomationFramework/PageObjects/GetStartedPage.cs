using OpenQA.Selenium;

namespace asp.netAutomationFramework.PageObjects
{
    class GetStartedPage
    {
        public GetStartedPage(IWebDriver driver)
        { this.driver = driver; }
        private IWebDriver driver;

        //Declare Home page locators 
        By getStartedLink = By.XPath("//a[text()=\"Get Started with ASP.NET\"]");
        By learnMoreLink = By.XPath("//a[text()=\"Learn more\"]");
        //Declare Home page methods
    }
}
