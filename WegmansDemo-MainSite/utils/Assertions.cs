using OpenQA.Selenium;

namespace WegmansDemo_MainSite.utils
{
    internal class Assertions : Base
    {
        public IWebDriver driver;
        public Assertions(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void AssertPageTitle(string pagetitle)
        {
            Assert.True(driver.Title == pagetitle);
        }

        public void AssertElementExist(IWebElement element, string message)
        {
            Assert.IsNotNull(element, message);
        }
    }
}
