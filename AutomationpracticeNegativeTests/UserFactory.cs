namespace AutomationpracticeNegativeTests
{
    public class UserFactory
    {
        public static UserRegistration CreateValidUser()
        {
            return new UserRegistration
            {
                RadioButtons = "1",
                FirstName = "Vanya",
                LastName = "Softuni",
                Password = "qaautomation123",
                Day = "3",
                Month = "3",
                Year = "1989",
                FirstNameForAddress = "Student",
                LastNameForAddress = "Softuni",
                Address = "Address",
                City = "Sofia",
                State = "Arizona",
                PostCode = "85001",
                MobilePhone = "85001",
                Alias = "Home"
            };
        }
    }
}
