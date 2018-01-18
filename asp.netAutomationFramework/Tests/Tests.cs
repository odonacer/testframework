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
            GetStartedPage getStartedPage = homePage.ClickOnGetStartedLink();
            getStartedPage.VerifyIfDisplayedDownnloadCoreLink();
        }

        [Test]
        public void DownloadFile() //test for a file downloading - doesn't work right now for some reason
        {
            homePage.OpenHomePage();
            homePage.DownloadVSComunity2017();            
        }

        [Test]
        public void SignUp() //signup test.
        {
            homePage.OpenHomePage();            
            SignUpPage signUpPage = homePage.OpenSignUpPage();
            signUpPage.SignUpUsinngMSAccount();           
        }

        [TearDown]
        public void CloseWebdriver()
        {
            homePage.CloseWebDriver();
        }
    }
}
