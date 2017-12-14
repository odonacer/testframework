using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.IO;
using System.Linq;

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
            ChromeOptions chromeOptions = new ChromeOptions();
            
            chromeOptions.AddUserProfilePreference("safebrowsing.enabled", true);
            chromeOptions.AddArguments("--start-maximized");
            driver = new ChromeDriver(chromeOptions);
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

        public void SendKeys(string keys, By element)





        { driver.FindElement(element).SendKeys(keys); }

        public void DownloadFile()
        {
            
            string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string downloadPath = Path.Combine(userPath, "Downloads");
            //Actions action = new Actions(driver);
            //IWebElement  elem = driver.FindElement(element);
            //action.MoveToElement(elem).Perform();
            
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("download.default_directory", downloadPath);
            chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
            //driver = new ChromeDriver(chromeOptions);
            DirectoryInfo dirInfo = new DirectoryInfo(downloadPath);
            dirInfo = new DirectoryInfo(downloadPath);
            int directoryFiles = dirInfo.EnumerateFiles().Count();
            int currentFiles = dirInfo.EnumerateFiles().Count();
            Assert.Greater(currentFiles, directoryFiles);
        }

    }
} 

