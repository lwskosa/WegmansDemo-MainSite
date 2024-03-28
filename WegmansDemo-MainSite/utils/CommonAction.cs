using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace WegmansDemo_MainSite.utils
{
    internal class CommonAction
    {
        WebDriverWait wait;
        public CommonAction(WebDriverWait wait)
        {
            this.wait = wait;
        }
        public void waitToClick(IWebElement locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator)).Click();
        }

    }
}
