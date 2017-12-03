using OpenQA.Selenium;
using NUnit.Framework;
using asp.netAutomationFramework.WebDriverAPIWrapper;
using OpenQA.Selenium.Chrome;

namespace asp.netAutomationFramework.PageObjects
{
    class BasePage : WebDriverAPI
    {    
        private IWebDriver driver;
        public BasePage(IWebDriver driver):base(driver)
        {
            this.driver = driver;
        }

        private string homePageURL = "http://asp.net";
#region NavigationBarVars
        By homeLink = By.LinkText("Home");        
        By getStartedLink = By.LinkText("Get Started");
        By learnLink = By.LinkText("Learn");
        By hostingLink = By.LinkText("Hosting");
        By downloadsLink = By.LinkText("Downloads");
        #endregion
#region SearchVars  
        By searchField = By.ClassName("search-input");
        By submitSearchRequest = By.ClassName("search-submit");
        By searchResultsForText = By.Id("search-title");
        #endregion
#region NavigationBarMethods
        public void OpenHomePageByURL()
        {
            NavigateToURL(homePageURL);
        }

        public HomePage ClickOnHomeLink()
        {
            NavigateByLink(homeLink);
            return new HomePage(driver);
        }

        public GetStartedPage ClickOnGetStartedLink()
        {
            NavigateByLink(getStartedLink);
            return new GetStartedPage(driver);
        }
        public void GoToLearnLinkPage()
        {
            driver.FindElement(learnLink).Click();
        }
        public void GoToHostingLinkPage()
        {
            driver.FindElement(hostingLink).Click();
        }
        public void GoToDownloadsPage()
        {
            driver.FindElement(downloadsLink).Click();
        }
        public void CloseWebDriver()
        {
            driver.Close();
        }

        public void VerifyTitle(string pageTitle)
        {
            Assert.AreEqual(driver.Title, pageTitle);
        }
        #endregion

        #region SearchMethods
        public BasePage PerformSearch(string searchKeyword)
        {
            driver.FindElement(searchField).SendKeys(searchKeyword);
            driver.FindElement(submitSearchRequest).Click();
            Assert.AreEqual(driver.FindElement(searchResultsForText), searchKeyword);
            return this;
        }
#endregion
    }
}
