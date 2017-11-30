using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using asp.netAutomationFramework.PageObjects;

namespace asp.netAutomationFramework
{
    public class Class1
    {
        IWebDriver driver;
        [SetUp]
        public void SetUp()
        { driver = new ChromeDriver(); }
        [Test]
        public void dosmt()
        {
            HomePage homePage = new HomePage(driver);
            NavigationBar navigation = new NavigationBar(driver);
            homePage.OpenHomePage();
            Search search = new Search(driver);
            search.PerformSearch("c#");
        }
    }
}
