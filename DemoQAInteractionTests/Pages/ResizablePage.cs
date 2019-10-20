using OpenQA.Selenium;

namespace DemoQAInteractionTests.Pages
{
    public class ResizablePage : BasePage
    {
        public ResizablePage(IWebDriver driver, int timeSpanFromSeconds = 2) :
            base(driver, timeSpanFromSeconds)
        {
        }

        public string Url => "https://demoqa.com/resizable/";

        public IWebElement ResizableElement => Wait.Until(d => d.FindElement(By.Id("resizable")));
    }
}
