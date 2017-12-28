using OpenQA.Selenium;
using NUnit.Framework;
namespace asp.netAutomationFramework.PageObjects
{
    class GetStartedPage : BasePage
    {
        
        private IWebDriver driver;
        public GetStartedPage():base()
        {
           this.driver = driver;
        }

        //Declare Home page locators 
        private By getStartedLink = By.XPath("//a[text()=\"Get Started with ASP.NET\"]");
        private By learnMoreLink = By.XPath("//a[text()=\"Learn more\"]");
        private By downloadCorelink = By.XPath("//a[@data-product=\".NET Core\"]");
        private string getStartedPageTitle = "Get Started with ASP.NET | The ASP.NET Site";
        
        //Declare Home page methods
        public void VerifyGetStartedTitle()
        {
            VerifyTitle(getStartedPageTitle);
        }

        public void VerifyIfDisplayedDownnloadCoreLink()
        {
            VerifyWebElement(downloadCorelink);
        }

    }
}
