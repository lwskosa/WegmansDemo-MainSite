using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Configuration;

namespace WegmansDemo_MainSite.pages
{

    internal class SharedPage
    {
        private IWebDriver driver;
        private string MAINPAGE_TITLE = ConfigurationManager.AppSettings["pagetitle_main"];
        public SharedPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }



        [FindsBy(How = How.XPath, Using = "//a[text()='Stores']")]
        private IWebElement headerLinStores;

        [FindsBy(How = How.XPath, Using = "//a[text()='Pharmacy']")]
        private IWebElement headerLinkPharmacy;


        [FindsBy(How = How.XPath, Using = "//a[text()='Bakery']")]
        private IWebElement categoriesBakery;

        [FindsBy(How = How.XPath, Using = "//a[text()='Cheese']")]
        private IWebElement categoriesCheese;

        [FindsBy(How = How.XPath, Using = "//a[text()='About Us']")]
        private IWebElement footerAboutUs;


        public IWebElement getHeaderLinkStores() { return headerLinStores; }
        public IWebElement getHeaderLinkPharmacy() { return headerLinkPharmacy; }
        public IWebElement getCategoryBakery() { return categoriesBakery; }
        public IWebElement getCategoryCheese() { return categoriesCheese; }
        public IWebElement getFooterLinkAboutUs() { return footerAboutUs; }
        

    }



}
