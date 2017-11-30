using OpenQA.Selenium;
using NUnit.Framework;

namespace asp.netAutomationFramework.PageObjects
{
    // To be implemented
    class Search
    {
        public Search(IWebDriver driver)
        { this.driver = driver; }
        private IWebDriver driver;

        By searchField = By.ClassName("search-input");
        By submitSearchRequest = By.ClassName("search-submit");
        By searchResultsForText = By.Id("search-title");

        public Search PerformSearch(string searchKeyword)
        {
            driver.FindElement(searchField).SendKeys(searchKeyword);
            driver.FindElement(submitSearchRequest).Click();
            Assert.AreEqual(driver.FindElement(searchResultsForText), searchKeyword);
            return new Search(driver);
        }

        
    }
}
