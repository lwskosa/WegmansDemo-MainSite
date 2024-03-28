using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Configuration;

namespace WegmansDemo_MainSite.pages
{

    internal class AboutUsPage
    {
        private IWebDriver driver;
        private string PAGETITLE = ConfigurationManager.AppSettings["pagetitle_aboutus"];
        public AboutUsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }



        [FindsBy(How = How.XPath, Using = "//h1[text()='about us']")]
        private IWebElement aboutUsSectionHeader;


        public IWebElement getAboutUsHeader() { return aboutUsSectionHeader; }
        

    }



}
