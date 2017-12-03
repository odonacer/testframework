using OpenQA.Selenium;

namespace asp.netAutomationFramework.PageObjects
{
    class HostingPage : BasePage
    {
        private IWebDriver driver;
        public HostingPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        
    }
}
