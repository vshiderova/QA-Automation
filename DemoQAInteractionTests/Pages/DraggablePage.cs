using OpenQA.Selenium;

namespace DemoQAInteractionTests.Pages
{
    public class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver, int timeSpanFromSeconds = 2) :
            base(driver, timeSpanFromSeconds)
        {
        }

        public string Url => "https://demoqa.com/draggable/";

        public IWebElement DraggableElement => Wait.Until(d => d.FindElement(By.Id("draggable")));
    }
}
