using OpenQA.Selenium;
using NUnit.Framework;
using asp.netAutomationFramework.WebDriverAPIWrapper;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

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
        By signUpLink = By.ClassName("nav-user logged-out");
        By joinMenuItem = By.XPath("//a[text()=\"Join\"]");
        private By usernameField = By.Id("Username");
        private By passwordField = By.Id("Password");
        private By joinWithMS = By.Id("Microsoft");
        private By signup = By.Id("signup");
        private By createMSAccountTitle = By.XPath("//*[text()=\"Create account\"]");
        private By downloadForWindowsLink = By.XPath("//a[text()=\"Download for Windows\"]");
        private By community2017 = By.XPath("//a[text()=\"Community 2017\"]");
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
        public LearnPage GoToLearnLinkPage()
        {
            NavigateByLink(learnLink);
            return new LearnPage(driver);
        }
        public HostingPage GoToHostingLinkPage()
        {
            NavigateByLink(homeLink);
            return new HostingPage(driver);
        }
        public DownloadsPage GoToDownloadsPage()
        {
            NavigateByLink(downloadsLink);
            return new DownloadsPage(driver);
        }
        public void CloseWebDriver()
        {
            driver.Close();
        }

        public void VerifyTitle(string pageTitle)
        {
            Assert.AreEqual(driver.Title, pageTitle);
        }

        public void ClickOnWebElement(By element)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            ClickOnElement(element);
        }

        public void VerifyWebElement(By element)
        {
            Assert.IsTrue(driver.FindElement(element).Displayed);
        }

        // Method implementation is in progress 
        public void SignUpViaMicrosoft()
        {
            ClickOnElement(signUpLink);
            ClickOnElement(joinMenuItem);
            ClickOnElement(joinWithMS);
            ClickOnElement(signup);
            VerifyWebElement(createMSAccountTitle);
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
