using OpenQA.Selenium;
using asp.netAutomationFramework.WebDriverAPIWrapper;
using OpenQA.Selenium.Chrome;

namespace asp.netAutomationFramework.PageObjects
{
    class HomePage : BasePage
    {
        public HomePage()
        {

        }
        public HomePage(IWebDriver driver): base(driver)
       {  }

        private IWebDriver driver; 

        WebDriverAPI baseAPI = new WebDriverAPI();
        private By downloadVS = By.XPath("//a[@data-product=\"Visual Studio\"]");
        private string basePageURL = "http://asp.net";
        //IWebElement downloadVS;
        public IWebElement DownloadVS
        {
            get { return baseAPI.FindElement(downloadVS); }
        }



        public void ClickOnDownloadVSLink()
        {
            baseAPI.ClickOnElement(DownloadVS);
        }
        public HomePage OpenHomePage()
        {
            baseAPI.NavigateByURL(basePageURL);
            return  this;
        }
    }
}
