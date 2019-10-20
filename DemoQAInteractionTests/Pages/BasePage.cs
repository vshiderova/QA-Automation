using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoQAInteractionTests.Pages
{
    public abstract class BasePage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public BasePage(IWebDriver driver, int timeSpanFromSeconds = 2)
        {
            _driver = driver;
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeSpanFromSeconds);

            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeSpanFromSeconds));
        }

        public IWebDriver Driver => _driver;

        public WebDriverWait Wait => _wait;

        public void DriverQuit()
        {
            _driver.Quit();
        }

        public virtual void Navigate(string url)
        {
            this.Driver.Url = url;
        }
    }
}
