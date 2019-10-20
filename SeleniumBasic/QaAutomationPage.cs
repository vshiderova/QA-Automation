using OpenQA.Selenium;

namespace SeleniumBasic
{
    public class QaAutomationPage : BasePage
    {
        public QaAutomationPage(IWebDriver driver, int timeSpanFromSeconds = 2)
            : base(driver, timeSpanFromSeconds)
        {
        }

        public IWebElement HeaderNav => Driver.FindElement(By.XPath(@"//*[@id=""header-nav""]/div[1]/ul/li[2]/a/span"));

        public IWebElement QaAutomationLink => Driver.FindElement(By.XPath(@"//*[@id=""header-nav""]/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/ul[2]/div[1]/ul/li/a"));

        public IWebElement H1 => Driver.FindElement(By.XPath(@"/html/body/div[2]/header/h1"));
    }
}
