using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace asp.netAutomationFramework.WebDriverAPIWrapper
{
    public  class WebDriverAPI
    {        
        private IWebDriver driver;
        public WebDriverAPI(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver StartChromeDriver()
        {
            driver = new ChromeDriver();
            return driver;
        }

        public void QuitWebBrowser()
        {
            driver.Quit();
        }

        public void ClickOnElement(By element)
        {
            driver.FindElement(element).Click();
        }

        public void NavigateToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void NavigateByLink(By link)
        {
            driver.FindElement(link).Click();
        }

    }
} 

