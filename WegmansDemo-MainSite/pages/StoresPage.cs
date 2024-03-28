using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Configuration;

namespace WegmansDemo_MainSite.pages
{
    internal class StoresPage
    {
        private IWebDriver driver;
        private string STORESPAGE_TITLE = ConfigurationManager.AppSettings["pagetitle_stores"];
        public StoresPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "northcarolinaTitle")]
        private IWebElement stateNCTitle;


        public IWebElement getStateNCTitle() { return stateNCTitle; }

        public string getStoresPageTitle() { return STORESPAGE_TITLE; }
    }
}
