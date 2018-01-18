using OpenQA.Selenium;
using asp.netAutomationFramework.WebDriverAPIWrapper;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace asp.netAutomationFramework.PageObjects
{
    class HomePage : BasePage
    {
        private IWebDriver driver;
        private By downloadCorelink = By.XPath("//a[@data-product=\".NET Core\"]");
        private By downloadVSlink = By.XPath("//a[@data-product=\"Visual Studio\"]");
        private By downloadVS = By.XPath("/descendant::span[@class='fusion-button-text'][2]");
        private string basePageURL = "http://asp.net"; //not used for the moment
        private string homePageTitle = "ASP.NET | The ASP.NET Site";
        private string downloadCorePageTitle = ".NET and C# - Get Started in 10 Minutes";
        private By freeCoursesLink = By.ClassName("free-courses");
        private By downloadVSForWindows = By.XPath("//a[text()=\"Download for Windows\"]");
        private By downloadComunity2017 = By.XPath("//a[text()=\"Community 2017\"]");

        public SignUpPage OpenSignUpPage()
        {
            ClickOnSignUpLink();
            return new SignUpPage();
        }

        public HomePage() :base()
        {       
        }

        public void OpenHomePage()
        {
            OpenHomePageByURL();
        }

        public void VerifyHomePageTitle()
        {
            BasePage.VerifyTitle(homePageTitle);
            Console.WriteLine("Verify method worked!");
        }

        public void ClickOnCoreDownloadLink()
        {
            ClickOnWebElement(downloadCorelink);
        }

        public void VerifyFreeCorsesLinkPresense()
        {
            VerifyWebElement(freeCoursesLink);
        }

        public void VerifyIfDisplayedDownnloadCoreLink()
        {
            VerifyWebElement(downloadCorelink);
        }

        public void VerifyIfDisplayedDownnloadVSLink()
        {
            VerifyWebElement(downloadVSlink);
        }

        public void DownloadVSComunity2017()
        {
            WebDriverAPI.ClickOnElement(downloadVSlink);
            string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string downloadPath = Path.Combine(userPath, "Downloads");
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("download.default_directory", downloadPath);
            DirectoryInfo dirInfo = new DirectoryInfo(downloadPath);
            dirInfo = new DirectoryInfo(downloadPath);
            int directoryFiles = dirInfo.EnumerateFiles().Count();
            Actions action = new Actions(driver);
            IWebElement elem = driver.FindElement(downloadVSForWindows);
            action.MoveToElement(elem).Perform();
            WebDriverAPI.ClickOnElement(downloadComunity2017);
            Thread.Sleep(10000);
            dirInfo = new DirectoryInfo(downloadPath);
            int currentFiles = dirInfo.EnumerateFiles().Count();
            Assert.Greater(currentFiles, directoryFiles);
        }
    }
}
