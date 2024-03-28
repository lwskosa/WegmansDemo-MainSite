using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Configuration;

namespace WegmansDemo_MainSite.pages
{

    internal class CategoryBreadPage
    {
        private IWebDriver driver;
        private string MAINPAGE_TITLE = ConfigurationManager.AppSettings["pagetitle_main"];
        public CategoryBreadPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }



        [FindsBy(How = How.CssSelector, Using = "[data-test='category-grid']")]
        private IWebElement breadList;

        [FindsBy(How = How.XPath, Using = "//a[text()='Pharmacy']")]
        private IWebElement headerLinkPharmacy;


        [FindsBy(How = How.XPath, Using = "//a[text()='Bakery']")]
        private IWebElement categoriesBakery;

        [FindsBy(How = How.XPath, Using = "//a[text()='Cheese']")]
        private IWebElement categoriesCheese;

        public IWebElement getBreadList() { return breadList; }
        public IWebElement getHeaderLinkPharmacy() { return headerLinkPharmacy; }
        

    }



}
