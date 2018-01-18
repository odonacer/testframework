using OpenQA.Selenium;
using NUnit.Framework;
using asp.netAutomationFramework.WebDriverAPIWrapper;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace asp.netAutomationFramework.PageObjects
{
    class BasePage
    {    
        static IWebDriver driver;
        public BasePage()
        {
            WebDriverAPI api = new WebDriverAPI();
            driver = api.StartChromeDriver();
        }
       
        private string homePageURL = "http://asp.net";
        #region NavigationBarVars
        private By homeLink = By.LinkText("Home");
        private By getStartedLink = By.LinkText("Get Started");
        private By learnLink = By.LinkText("Learn");
        private By hostingLink = By.LinkText("Hosting");
        private By downloadsLink = By.LinkText("Downloads");
        #endregion
        #region SearchVars  
        private By searchField = By.ClassName("search-input");
        private By submitSearchRequest = By.ClassName("search-submit");
        private By searchResultsForText = By.Id("search-title");
        private By signUpLink = By.XPath("//div[contains(@class, 'nav-user logged-out')]");
        private By joinMenuItem = By.XPath("//a[text()=\"Join\"]");
        private By usernameField = By.Id("Username");
        private By passwordField = By.Id("Password");        
        private By signup = By.Id("signup");
        private By createMSAccountTitle = By.XPath("//*[text()=\"Create account\"]");
        private By downloadForWindowsLink = By.XPath("//a[text()=\"Download for Windows\"]");
        private By community2017 = By.XPath("//a[text()=\"Community 2017\"]");
        #endregion
        #region NavigationBarMethods
        public void OpenHomePageByURL()
        {
           WebDriverAPI.NavigateToURL(homePageURL);            
        }

        public void ClickOnSignUpLink()
        {
            WebDriverAPI.NavigateByLink(signUpLink);
        }

        public void ClickOnHomeLink()
        {
            WebDriverAPI.NavigateByLink(homeLink);
        }

        public GetStartedPage ClickOnGetStartedLink()
        {
            WebDriverAPI.NavigateByLink(getStartedLink);
            return new GetStartedPage();
        }
        public LearnPage GoToLearnLinkPage()
        {
            WebDriverAPI.NavigateByLink(learnLink);
            return new LearnPage();
        }
        public HostingPage GoToHostingLinkPage()
        {
            WebDriverAPI.NavigateByLink(homeLink);
            return new HostingPage();
        }
        public DownloadsPage GoToDownloadsPage()
        {
            WebDriverAPI.NavigateByLink(downloadsLink);
            return new DownloadsPage();
        }
        public void CloseWebDriver()
        {
            driver.Close();
        }

        public static void VerifyTitle(string pageTitle)
        {
            Assert.AreEqual(driver.Title, pageTitle);
        }

        public static void ClickOnWebElement(By element)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            WebDriverAPI.ClickOnElement(element);
        }

        public static void VerifyWebElement(By element)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Assert.IsTrue(driver.FindElement(element).Displayed);
        }

        public void VerifyCreateMSAccount()
        {
            Assert.AreEqual(driver.FindElement(createMSAccountTitle).Text, "Create account");
        }

        public SignUpPage SignUpViaMicrosoft()
        {
            ClickOnWebElement(joinMenuItem);
            return new SignUpPage();
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
