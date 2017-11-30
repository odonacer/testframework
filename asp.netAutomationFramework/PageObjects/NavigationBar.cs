using OpenQA.Selenium;
namespace asp.netAutomationFramework.PageObjects
{
    class NavigationBar
    {
        public NavigationBar(IWebDriver driver)
        { this.driver = driver; }
        private IWebDriver driver;

        By homeLink = By.LinkText("Home");
        By getStartedLink = By.LinkText("Get Started");
        By learnLink = By.LinkText("Learn");
        By hostingLink = By.LinkText("Hosting");
        By downloadsLink = By.LinkText("Downloads");
        

        public void GoToHome()
        {
            driver.FindElement(homeLink).Click();
        }

        public void GoToDownloads()
        { driver.FindElement(downloadsLink).Click(); }
    }
}
