using OpenQA.Selenium;

namespace asp.netAutomationFramework.PageObjects
{
    class HostingPage : BasePage
    {
        private IWebDriver driver;
        public HostingPage() : base()
        {
            this.driver = driver;
        }
        
    }
}
