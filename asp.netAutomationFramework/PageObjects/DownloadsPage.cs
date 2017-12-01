using OpenQA.Selenium;

namespace asp.netAutomationFramework.PageObjects
{
    class DownloadsPage
    {
        public DownloadsPage(IWebDriver driver)
        { this.driver = driver; }
        private IWebDriver driver;
    }
}
