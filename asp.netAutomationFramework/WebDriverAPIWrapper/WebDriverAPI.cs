using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace asp.netAutomationFramework.WebDriverAPIWrapper
{
    class WebDriverAPI
    {
        public WebDriverAPI()
        {
                
        }

        public WebDriverAPI(IWebDriver driver)
            { this.driver = driver; }
        private IWebDriver driver;
        public IWebDriver SetDriver()
        { return driver; }
        public void StartChromeWebBrowser()
        {
            driver = new ChromeDriver();
        }

        public void QuitWebBrowser()
        {
            driver.Quit();
        }

        public void NavigateByLinkElement(By element)
        {
            driver.FindElement(element).Click();
        }

        public void NavigateByURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        
        public IWebElement FindElement(By element)
        {
            var foundElement = driver.FindElement(element);
            return foundElement;
        }

        public void ClickOnElement(IWebElement element)
        {
            element.Click();
        }
        
       
        }
    }

