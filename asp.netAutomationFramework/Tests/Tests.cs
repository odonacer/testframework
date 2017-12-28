using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using asp.netAutomationFramework.PageObjects;
using asp.netAutomationFramework.WebDriverAPIWrapper;

namespace asp.netAutomationFramework
{
    public class Tests
    {

        HomePage homePage;
        BasePage basePage;
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            homePage = new HomePage();
            
        }

        [Test]
        public void GoFromHomePageToGetStartedPage() //test shows basic page navigaions along with page's title verification
        {
            homePage.OpenHomePage();
            
        homePage.VerifyHomePageTitle();
            
           // GetStartedPage getStartedPage = new GetStartedPage();
           // getStartedPage.VerifyIfDisplayedDownnloadCoreLink();
        }

        [Test]
        public void DownloadFile()
        {
            
            HomePage homePage = new HomePage();
            homePage.DownloadVSComunity2017();
            
        }

        [Test]
        public void SignUp()
        {
           
           
        }

        [TearDown]
        public void CloseWebdriver()
        {
            homePage.CloseWebDriver();
        }
    }
}
