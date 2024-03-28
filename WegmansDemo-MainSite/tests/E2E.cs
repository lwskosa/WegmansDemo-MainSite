using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Configuration;
using WegmansDemo_MainSite.pages;
using WegmansDemo_MainSite.utils;

namespace WegmansDemo_MainSite.tests
{
    public class E2E : Base
    {
        [Test]
        public void NavigateHome()
        {
            Assertions assertions = new Assertions(driver);
            MainPage mainPage = new MainPage(driver);

            mainPage.getWegmansLogo().Click();

            assertions.AssertPageTitle(mainPage.getMainPageTitle());
            //Assert.True(driver.Title == ConfigurationManager.AppSettings["pagetitle_main"]);
        }
        [Test]
        public void SearchProduct()
        {
            Assertions assertions = new Assertions(driver);
            MainPage mainPage = new MainPage(driver);
            CommonAction action = new CommonAction(wait);
            Thread.Sleep(1000);
            mainPage.getSearchBar().SendKeys("Milk");
            mainPage.getSearchBar().SendKeys(Keys.Enter);
            action.waitToClick(mainPage.getShopIntentStore());
            Thread.Sleep(1000);
            mainPage.getShopIntentStore().Click();

            action.waitToClick(mainPage.getSentryReload());


            assertions.AssertElementExist(mainPage.getSearchBar(), "Search Result does not exist");
                //Assert.IsNotNull(mainPage.getSearchBar(), "Search result does not exist");

        }

        [Test]
        public void NavigateHeaderStore()
        {
            Assertions assertions = new Assertions(driver);
            SharedPage sharedPage = new SharedPage(driver);
            StoresPage storesPage = new StoresPage(driver);
            Thread.Sleep(1000);
            sharedPage.getHeaderLinkStores().Click();
            Assert.True(driver.Title == storesPage.getStoresPageTitle(), $"\nExpected: {storesPage.getStoresPageTitle()}\nActual:{driver.Title}");
            Assert.IsNotNull(storesPage.getStateNCTitle(), "North Carolina section was not found");

        }
        [Test]
        public void NavigateCategoriesMenu()
        {
            SharedPage  sharedPage = new SharedPage(driver);
            CategoryBreadPage breadPage = new CategoryBreadPage(driver);

            sharedPage.getCategoryBakery().Click();
            Assert.IsNotNull(breadPage.getBreadList());



        }
        
        public void NavigateFooterAboutUs()
        {
            SharedPage sharedPage = new SharedPage(driver);
            AboutUsPage aboutUsPage = new AboutUsPage(driver);
            sharedPage.getFooterLinkAboutUs().Click();
            Assert.IsNotNull(aboutUsPage.getAboutUsHeader());
        }
    }
}