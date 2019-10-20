using OpenQA.Selenium;

namespace DemoQAInteractionTests.Pages
{
    public class DroppablePage : BasePage
    {
        public DroppablePage(IWebDriver driver, int timeSpanFromSeconds = 2) :
            base(driver, timeSpanFromSeconds)
        {
        }

        public string Url => "https://demoqa.com/droppable/";

        public IWebElement DraggableElement => Wait.Until(d => d.FindElement(By.Id("draggable")));

        public IWebElement DroppableElement => Wait.Until(d => d.FindElement(By.Id("droppable")));
    }
}
