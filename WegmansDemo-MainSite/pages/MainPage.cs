using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Configuration;

namespace WegmansDemo_MainSite.pages
{

    internal class MainPage
    {
        private IWebDriver driver;
        private string MAINPAGE_TITLE = ConfigurationManager.AppSettings["pagetitle_main"];
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.Id, Using = "wegmansLogo")]
        private IWebElement wegmanslogo;

                [FindsBy(How = How.Id, Using = "nav-register")]
        private IWebElement loginLink;

                [FindsBy(How = How.XPath, Using = "/html/body/div[5]/header/div[11]/div[1]/unata-search-nav/div/form/input")]
        private IWebElement searchBar;
        
                [FindsBy(How = How.CssSelector, Using = "[aria-label='Submit Search']")]
        private IWebElement searchButton;

              
                [FindsBy(How = How.Id, Using = "shopping-selector-shop-context-intent-instore")]
        private IWebElement shopIntentStore;

              
                [FindsBy(How = How.XPath, Using = "//button[text()='Reload']")]
        private IWebElement sentryReload;
                      
                [FindsBy(How = How.XPath, Using = "shop-products-items")]
        private IWebElement searchResults;


        [FindsBy(How = How.XPath, Using = "//button[text()='Stores']")]
        private IWebElement headerLinStores;




        [FindsBy(How = How.Id, Using = "[data-test='carousel-content']")]
        private IWebElement collectionCarousel;


        public IWebElement getWegmansLogo() { return wegmanslogo; }

        public IWebElement getLoginLink() {  return loginLink; }
        public IWebElement getSearchBar() { return searchBar; }

        public IWebElement getShopIntentStore() {  return shopIntentStore; }
        public IWebElement getSearchButton() { return searchButton; }

        public IWebElement getSentryReload() {  return sentryReload; }
        public IWebElement getCollectionCarousel() { return collectionCarousel; }
        public IWebElement getSearchResults() { return searchResults; }
        public IWebElement getHeaderLinkStores() { return headerLinStores; }
        public string getMainPageTitle()
        {
            return MAINPAGE_TITLE;
        }

    }



}
