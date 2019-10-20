using System;
using System.IO;
using System.Reflection;

using AutomationpracticeNegativeTests.Pages;

using NUnit.Framework;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationpracticeNegativeTests
{
    [TestFixture]
    public class POMTests
    {
        private LoginPage _loginPage;
        private RegistrationPage _regPage;
        private UserRegistration _user;

        [SetUp]
        public void CalssInit()
        {
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            _loginPage = new LoginPage(driver);
            _regPage = new RegistrationPage(driver);

            _user = UserFactory.CreateValidUser();
        }
    }
   
}
