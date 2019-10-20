using OpenQA.Selenium;

namespace DemoQAInteractionTests.Pages
{
    public class SortablePage : BasePage
    {
        public SortablePage(IWebDriver driver, int timeSpanFromSeconds = 2) :
            base(driver, timeSpanFromSeconds)
        {
        }

        public string Url => "https://demoqa.com/sortable/";
        public IWebElement SortableElement1 => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""sortable""]/li[1]")));

        public IWebElement SortableElement2 => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""sortable""]/li[2]")));
    }
}
