using OpenQA.Selenium;

namespace asp.netAutomationFramework.PageObjects
{
    class HomePage
    {
        public HomePage(IWebDriver driver)
        { this.driver = driver; }

        private IWebDriver driver;
        string homePageURL = "https://www.asp.net/";
        //Declare Home page locators 
        By homeLink = By.LinkText("Home");
        By getStartedLink = By.LinkText("Get Started");
        By learnLink = By.LinkText("Learn");
        By hostingLink = By.LinkText("Hosting");
        By downloadsLink = By.LinkText("Downloads");
        By searchField = By.ClassName("search-input");


        //Declare Home page methods
        public HomePage OpenHomePage()
        { driver.Navigate().GoToUrl(homePageURL);
            return new HomePage(driver); }

        public GetStartedPage GoToGetStartedPage()
        {
            driver.FindElement(getStartedLink).Click();
            return new GetStartedPage(driver);
        }
    }
}
