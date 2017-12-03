using OpenQA.Selenium;

namespace asp.netAutomationFramework.PageObjects
{
    class LearnPage : BasePage
    {
        private IWebDriver driver;
        public LearnPage(IWebDriver driver) :base(driver)
        {
            this.driver = driver;
        }
        
    }
}
