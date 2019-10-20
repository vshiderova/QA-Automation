﻿using System.Collections.Generic;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationpracticeNegativeTests.Pages
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        public string Url => "http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation";

        public IList<IWebElement> RadioButtons => Wait.Until(d => d.FindElements(By.XPath("//div[@class='radio']//input")));

        public IWebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement LastName => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement Password => Driver.FindElement(By.Id("passwd"));

        public SelectElement Day
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("days"));
                return new SelectElement(reminder);
            }
        }

        public SelectElement Month
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("months"));
                return new SelectElement(reminder);
            }
        }

        public SelectElement Year
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("years"));
                return new SelectElement(reminder);
            }
        }

        public IWebElement FirstNameForAddress => Driver.FindElement(By.Id("firstname"));

        public IWebElement LastNameForAddress => Driver.FindElement(By.Id("lastname"));

        public IWebElement Address => Driver.FindElement(By.Id("address1"));

        public IWebElement City => Driver.FindElement(By.Id("city"));

        public SelectElement State
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("id_state"));
                return new SelectElement(reminder);
            }
        }

        public IWebElement PostCode => Driver.FindElement(By.Id("postcode"));

        public IWebElement MobilePhone => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement Alias => Driver.FindElement(By.Id("alias"));

        public IWebElement RegisterButton => Driver.FindElement(By.Id("submitAccount"));

        public IWebElement ErrorMessage => Driver.FindElement(By.XPath(@"//*[@id=""center_column""]/div/ol/li"));
    }
}
