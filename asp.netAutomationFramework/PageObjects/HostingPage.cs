using OpenQA.Selenium;

namespace asp.netAutomationFramework.PageObjects
{
    class HostingPage
    {
        public HostingPage(IWebDriver driver)
        { this.driver = driver; }
        private IWebDriver driver;
    }
}
