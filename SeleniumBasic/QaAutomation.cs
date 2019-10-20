using System;
using System.IO;
using System.Reflection;

using NUnit.Framework;

using OpenQA.Selenium.Chrome;

namespace SeleniumBasic
{
    [TestFixture]
    public class QaAutomation
    {
        private ChromeDriver _driver;
        private QaAutomationPage _qaAutomationPage;

        [SetUp]
        public void CalssInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            _qaAutomationPage = new QaAutomationPage(_driver);
        }

        [Test]
        public void QaAutomationPage()
        {
            // Arrange
            _qaAutomationPage.Navigate("https://softuni.bg");

            // Act
            var headerNav = _qaAutomationPage.HeaderNav;

            headerNav.Click();

            var qaAutomationLink = _qaAutomationPage.QaAutomationLink;

            qaAutomationLink.Click();

            var h1 = _qaAutomationPage.H1;

            // Assert
            Assert.IsNotNull(h1);
            Assert.AreEqual("QA Automation - септември 2019", h1.Text);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
