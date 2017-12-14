using OpenQA.Selenium;
using asp.netAutomationFramework.WebDriverAPIWrapper;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;
using OpenQA.Selenium.Support.UI;

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

        public void DownloadVS()
        {
            ClickOnElement(downloadVSlink);
            
            

                string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string downloadPath = Path.Combine(userPath, "Downloads");
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(10));


                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddUserProfilePreference("download.default_directory", downloadPath);
                DirectoryInfo dirInfo = new DirectoryInfo(downloadPath);
                dirInfo = new DirectoryInfo(downloadPath);
                int directoryFiles = dirInfo.EnumerateFiles().Count();

            ClickOnElement(downloadVS);
           
            dirInfo = new DirectoryInfo(downloadPath);
            int currentFiles = dirInfo.EnumerateFiles().Count();
                Assert.Greater(currentFiles, directoryFiles);
            

        }
    }
}
