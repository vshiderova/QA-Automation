using System.IO;
using System.Reflection;

using DemoQAInteractionTests.Pages;

using NUnit.Framework;

using OpenQA.Selenium.Chrome;

namespace DemoQAInteractionTests
{
    [TestFixture]
    public class SelectableTests
    {
        private ChromeDriver _driver;
        private SelectablePage _selectablePage;

        [SetUp]
        public void Init()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _selectablePage = new SelectablePage(_driver, 2);
        }

        [Test]
        public void TestSelectedItem1()
        {
            // Arrange
            _selectablePage.Navigate(_selectablePage.Url);

            // Act
            var selectedItem = _selectablePage.SelectableElement1;
            selectedItem.Click();

            var selectedItem1CssClasses = selectedItem.GetAttribute("class");

            // Assert
            Assert.IsTrue(selectedItem1CssClasses.Contains("ui-selected"));
        }

        [Test]
        public void TestAllSelectedItems()
        {
            // Arrange
            _selectablePage.Navigate(_selectablePage.Url);

            // Act
            var selectedItem1 = _selectablePage.SelectableElement1;
            selectedItem1.Click();
            var selectedItem1CssClasses = selectedItem1.GetAttribute("class");

            var selectedItem2 = _selectablePage.SelectableElement2;
            selectedItem2.Click();
            var selectedItem2CssClasses = selectedItem2.GetAttribute("class");

            var selectedItem3 = _selectablePage.SelectableElement3;
            selectedItem3.Click();
            var selectedItem3CssClasses = selectedItem3.GetAttribute("class");

            var selectedItem4 = _selectablePage.SelectableElement4;
            selectedItem4.Click();
            var selectedItem4CssClasses = selectedItem4.GetAttribute("class");

            var selectedItem5 = _selectablePage.SelectableElement5;
            selectedItem5.Click();
            var selectedItem5CssClasses = selectedItem5.GetAttribute("class");

            var selectedItem6 = _selectablePage.SelectableElement6;
            selectedItem6.Click();
            var selectedItem6CssClasses = selectedItem6.GetAttribute("class");

            var selectedItem7 = _selectablePage.SelectableElement7;
            selectedItem7.Click();
            var selectedItem7CssClasses = selectedItem7.GetAttribute("class");

            // Assert
            Assert.IsTrue(selectedItem1CssClasses.Contains("ui-selected"));
            Assert.IsTrue(selectedItem2CssClasses.Contains("ui-selected"));
            Assert.IsTrue(selectedItem3CssClasses.Contains("ui-selected"));
            Assert.IsTrue(selectedItem4CssClasses.Contains("ui-selected"));
            Assert.IsTrue(selectedItem5CssClasses.Contains("ui-selected"));
            Assert.IsTrue(selectedItem6CssClasses.Contains("ui-selected"));
            Assert.IsTrue(selectedItem7CssClasses.Contains("ui-selected"));
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
