using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using asp.netAutomationFramework.PageObjects;
using asp.netAutomationFramework.WebDriverAPIWrapper;

namespace asp.netAutomationFramework
{
    public class Tests
    {
        BasePage basePage;
        IWebDriver driver;
        WebDriverAPI webAPI;

        [SetUp]
        public void SetUp()
        {
            basePage = new BasePage(driver);
            driver = basePage.StartChromeDriver();           
        }

        [Test]
        public void GoFromHomePageToGetStartedPage() //test shows basic page navigaions along with page's title verification
        {
            basePage.OpenHomePageByURL();
            HomePage homePage = new HomePage(driver);
            homePage.VerifyHomePageTitle();
            basePage.ClickOnGetStartedLink();
            GetStartedPage getStartedPage = new GetStartedPage(driver);
            getStartedPage.VerifyIfDisplayedDownnloadCoreLink();
        }

        [Test]
        public void DownloadFile()
        {
            basePage.OpenHomePageByURL();
            HomePage homePage = new HomePage(driver);
            homePage.DownloadVSComunity2017();
            
        }

        [Test]
        public void SignUp()
        {
            basePage = new BasePage(driver);
            basePage.OpenHomePageByURL();
            basePage.SignUpViaMicrosoft();
            basePage.VerifyCreateMSAccount();
           
        }
                
        [TearDown]
        public void CloseWebdriver()
        {
            webAPI = new WebDriverAPI(driver);
            webAPI.QuitWebBrowser();
        }
    }
}
