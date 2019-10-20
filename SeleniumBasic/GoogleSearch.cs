using System;
using System.IO;
using System.Reflection;

using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasic
{
    [TestFixture]
    public class GoogleSearch
    {
        private ChromeDriver _driver;
        private GoogleSearchPage _googleSearchPage;

        [SetUp]
        public void CalssInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            _googleSearchPage = new GoogleSearchPage(_driver, 2);
        }

        [Test]
        public void OpenSelenium()
        {
            // Arrange
            _googleSearchPage.Navigate("http://www.google.com");

            string searchText = "Selenium";

            // Act
            var searchInput = _googleSearchPage.SearchInput;

            searchInput.SendKeys(searchText);
            searchInput.SendKeys(Keys.Return);

            var firstResult = _googleSearchPage.FirstResult;

            firstResult.Click();

            var title = _driver.Title;

            // Assert
            Assert.AreEqual("Selenium - Web Browser Automation", title);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
