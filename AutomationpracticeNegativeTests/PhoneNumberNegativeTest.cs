﻿using System;
using System.IO;
using System.Reflection;

using AutomationpracticeNegativeTests.Pages;

using NUnit.Framework;

using OpenQA.Selenium.Chrome;

namespace AutomationpracticeNegativeTests
{
    [TestFixture]
    public class PhoneNumberNegativeTest
    {
        private ChromeDriver _driver;
        private LoginPage _loginPage;
        private RegistrationPage _regPage;
        private UserRegistration _user;

        [SetUp]

        public void CalssInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            _loginPage = new LoginPage(_driver);
            _regPage = new RegistrationPage(_driver);

            _user = UserFactory.CreateValidUser();
        }

        [Test]
        public void PhoneNumberErrorMessage()
        {
            _user.MobilePhone = string.Empty;
            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("You must register at least one phone number.");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
