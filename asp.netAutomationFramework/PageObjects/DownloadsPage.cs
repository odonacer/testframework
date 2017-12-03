using OpenQA.Selenium;

namespace asp.netAutomationFramework.PageObjects
{
    class DownloadsPage : BasePage
    {
        private IWebDriver driver;
        public DownloadsPage(IWebDriver driver): base(driver)
        {
            this.driver = driver;
        }
        
    }
}
