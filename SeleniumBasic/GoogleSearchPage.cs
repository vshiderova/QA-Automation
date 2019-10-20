using OpenQA.Selenium;

namespace SeleniumBasic
{
    public class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(IWebDriver driver, int timeSpanFromSeconds = 2)
            : base(driver, timeSpanFromSeconds)
        {
        }

        public IWebElement SearchInput => Driver.FindElement(By.XPath(@"//*[@id=""tsf""]/div[2]/div[1]/div[1]/div/div[2]/input"));

        public IWebElement FirstResult => Driver.FindElement(By.XPath(@"//*[@id=""rso""]/div[1]/div/div/div/div[1]/a[1]"));
    }
}
