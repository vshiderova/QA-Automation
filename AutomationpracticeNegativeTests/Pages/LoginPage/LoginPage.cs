﻿using OpenQA.Selenium;

namespace AutomationpracticeNegativeTests.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) 
            : base(driver)
        {
        }

        public string Url => "http://automationpractice.com/index.php?controller=my-account";

        public IWebElement Email => Driver.FindElement(By.Id("email_create"));

        public IWebElement Submit => Driver.FindElement(By.Id("SubmitCreate"));
    }
}
