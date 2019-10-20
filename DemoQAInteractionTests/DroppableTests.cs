using System.IO;
using System.Reflection;

using DemoQAInteractionTests.Pages;

using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace DemoQAInteractionTests
{
    [TestFixture]
    public class DroppableTests
    {
        private ChromeDriver _driver;
        private DroppablePage _droppablePage;

        [SetUp]
        public void Init()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _droppablePage = new DroppablePage(_driver, 2);
        }

        [Test]
        public void DroppableItem()
        {
            // Arrange
            _droppablePage.Navigate(_droppablePage.Url);

            // Act
            var draggable = _driver.FindElement(By.Id("draggable"));
            var droppable = _driver.FindElement(By.Id("droppable"));

            var actions = new Actions(_driver);

            actions
                .DragAndDrop(draggable, droppable)
                .Perform();

            var droppableText = _driver.FindElement(By.XPath(@"//*[@id=""droppable""]/p")).Text;

            // Assert
            Assert.AreEqual("Dropped!", droppableText);
        }

        [Test]
        public void DroppableItemWithOffset()
        {
            // Arrange
            _droppablePage.Navigate(_droppablePage.Url);

            // Act
            var draggable = _driver.FindElement(By.Id("draggable"));
            var droppable = _driver.FindElement(By.Id("droppable"));

            var actions = new Actions(_driver);

            actions
                .Click(draggable)
                .ClickAndHold(draggable)
                .DragAndDropToOffset(droppable, 10, 10)
                .Perform();

            var droppableText = _driver.FindElement(By.XPath(@"//*[@id=""droppable""]/p")).Text;

            // Assert
            Assert.AreEqual("Dropped!", droppableText);
        }

        [Test]
        public void DroppableItemWithNegativeOffset()
        {
            // Arrange
            _droppablePage.Navigate(_droppablePage.Url);

            // Act
            var draggable = _driver.FindElement(By.Id("draggable"));
            var droppable = _driver.FindElement(By.Id("droppable"));

            var actions = new Actions(_driver);

            actions
                .Click(draggable)
                .ClickAndHold(draggable)
                .DragAndDropToOffset(droppable, -10, -10)
                .Perform();

            var droppableText = _driver.FindElement(By.XPath(@"//*[@id=""droppable""]/p")).Text;

            // Assert
            Assert.AreEqual("Dropped!", droppableText);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}