using NUnit.Framework;

namespace AutomationpracticeNegativeTests.Pages
{
    public partial class RegistrationPage
    {
        public void AssertErrorMessage(string expected)
        {
            Assert.AreEqual(expected, ErrorMessage.Text);
        }
    }
}
