using System.IO;
using System.Reflection;

using DemoQAInteractionTests.Pages;

using NUnit.Framework;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace DemoQAInteractionTests
{
    [TestFixture]
    public class DraggableTests
    {
        private ChromeDriver _driver;
        private DraggablePage _draggablePage;

        [SetUp]
        public void Init()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _draggablePage = new DraggablePage(_driver, 2);
        }

        [Test]
        public void MoveDraggableBox()
        {
            // Arrange
            _draggablePage.Navigate(_draggablePage.Url);

            // Act
            var draggable = _draggablePage.DraggableElement;

            var draggableLocationX = draggable.Location.X;
            var draggableLocationY = draggable.Location.Y;

            var moveX = 150;
            var moveY = 50;
            var actions = new Actions(_driver);

            actions
                .Click(draggable)
                .ClickAndHold(draggable)
                .MoveByOffset(moveX, moveY)
                .Perform();

            // Assert
            Assert.AreEqual(draggableLocationX + moveX, draggable.Location.X);
            Assert.AreEqual(draggableLocationY + moveY, draggable.Location.Y);
        }

        [Test]
        public void MoveDraggableBoxNegativeY()
        {
            // Arrange
            _draggablePage.Navigate(_draggablePage.Url);

            // Act
            var draggable = _draggablePage.DraggableElement;

            var draggableLocationX = draggable.Location.X;
            var draggableLocationY = draggable.Location.Y;

            var moveX = 150;
            var moveY = -50;
            var actions = new Actions(_driver);

            actions
                .Click(draggable)
                .ClickAndHold(draggable)
                .MoveByOffset(moveX, moveY)
                .Perform();

            // Assert
            Assert.AreEqual(draggableLocationX + moveX, draggable.Location.X);
            Assert.AreEqual(draggableLocationY + moveY, draggable.Location.Y);
        }

        [Test]
        public void MoveDraggableBoxNegativeX()
        {
            // Arrange
            _draggablePage.Navigate(_draggablePage.Url);

            // Act
            var draggable = _draggablePage.DraggableElement;

            var draggableLocationX = draggable.Location.X;
            var draggableLocationY = draggable.Location.Y;

            var moveX = -150;
            var moveY = 50;
            var actions = new Actions(_driver);

            actions
                .Click(draggable)
                .ClickAndHold(draggable)
                .MoveByOffset(moveX, moveY)
                .Perform();

            // Assert
            Assert.AreEqual(draggableLocationX + moveX, draggable.Location.X);
            Assert.AreEqual(draggableLocationY + moveY, draggable.Location.Y);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
