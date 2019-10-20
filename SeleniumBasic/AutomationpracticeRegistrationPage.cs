using OpenQA.Selenium;

namespace SeleniumBasic
{
    public class AutomationpracticeRegistrationPage : BasePage
    {
        public AutomationpracticeRegistrationPage(IWebDriver driver, int timeSpanFromSeconds = 2)
            : base(driver, timeSpanFromSeconds)
        {
        }

        public IWebElement SignInButton => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""header""]/div[2]/div/div/nav/div[1]/a")));

        public IWebElement ValidEmailInput => Wait.Until(d => d.FindElement(By.Id("email_create")));

        public IWebElement CreateAccButton => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""SubmitCreate""]/span")));

        public string CheckEmailValue => Wait.Until(d => d.FindElement(By.Id("email"))).GetAttribute("value");
    }
}
