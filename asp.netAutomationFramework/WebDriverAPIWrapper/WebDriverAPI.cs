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
        static IWebDriver driver;
         static WebDriverAPI()
        {
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

        public static void ClickOnElement(By element)
        {
            driver.FindElement(element).Click();
        }

        public static void NavigateToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void NavigateByLink(By link)
        {
            driver.FindElement(link).Click();
        }

        public static void EnterText (string keys, By element)
        {
            driver.FindElement(element).SendKeys(keys);
        }

    }
} 

