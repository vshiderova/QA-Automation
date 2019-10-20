using OpenQA.Selenium;

namespace DemoQAInteractionTests.Pages
{
    public class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver, int timeSpanFromSeconds = 2) :
            base(driver, timeSpanFromSeconds)
        {
        }

        public string Url => "https://demoqa.com/selectable/";

        public IWebElement SelectableElement1 => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""selectable""]/li[1]")));
        
        public IWebElement SelectableElement2 => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""selectable""]/li[2]")));
        
        public IWebElement SelectableElement3 => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""selectable""]/li[3]")));
        
        public IWebElement SelectableElement4 => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""selectable""]/li[4]")));
        
        public IWebElement SelectableElement5 => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""selectable""]/li[5]")));
        
        public IWebElement SelectableElement6 => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""selectable""]/li[6]")));
        
        public IWebElement SelectableElement7 => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""selectable""]/li[7]")));
    }
}
