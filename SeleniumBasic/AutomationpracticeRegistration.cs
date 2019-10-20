using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace SeleniumBasic
{
    [TestFixture]
    public class AutomationpracticeRegistration
    {
        private ChromeDriver _driver;
        private WebDriverWait _wait;
        private AutomationpracticeRegistrationPage _automationpracticeRegistrationPage;

        [SetUp]
        public void CalssInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            _automationpracticeRegistrationPage = new AutomationpracticeRegistrationPage(_driver, 2);
        }

        [Test]
        public void ValidateEmail()
        {
            // Arrange
            _automationpracticeRegistrationPage.Navigate("http://automationpractice.com/index.php");

            // Act
            var signInButton = _automationpracticeRegistrationPage.SignInButton;
            signInButton.Click();

            _automationpracticeRegistrationPage.Wait.Timeout = new TimeSpan(2000);

            var validEmailInput = _automationpracticeRegistrationPage.ValidEmailInput;
            var randomEmail = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 7) + "@" + "gmail.bg";
            validEmailInput.SendKeys(randomEmail);

            var createAccButton = _automationpracticeRegistrationPage.CreateAccButton;
            createAccButton.Click();

            _automationpracticeRegistrationPage.Wait.Timeout = new TimeSpan(2000);

            var checkEmail = _automationpracticeRegistrationPage.CheckEmailValue;

            // Assert
            Assert.AreEqual(randomEmail, checkEmail);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}

