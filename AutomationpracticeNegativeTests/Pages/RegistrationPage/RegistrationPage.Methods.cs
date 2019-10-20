using System;

namespace AutomationpracticeNegativeTests.Pages
{
    public partial class RegistrationPage
    {
      
        public void FillForm(UserRegistration user)
        {
            RadioButtons[1].Click();
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Password.SendKeys(user.Password);
            Day.SelectByValue(user.Day);
            Month.SelectByValue(user.Month);
            Year.SelectByValue(user.Year);
            FirstNameForAddress.Clear();
            FirstNameForAddress.SendKeys(user.FirstNameForAddress);
            LastNameForAddress.Clear();
            LastNameForAddress.SendKeys(user.LastNameForAddress);
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            State.SelectByText(user.State);
            PostCode.SendKeys(user.PostCode);
            MobilePhone.SendKeys(user.MobilePhone);
            Alias.SendKeys(user.Alias);
            RegisterButton.Click();
        }

        public void Navigate(LoginPage loginPage)
        {
            loginPage.Navigate("http://automationpractice.com/index.php?controller=my-account");

            loginPage.Email.SendKeys(Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 7) + "@" + "gmail.bg");
            loginPage.Submit.Click();
        }
    }
}
