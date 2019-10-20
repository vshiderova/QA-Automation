using System.IO;
using System.Reflection;

using DemoQAInteractionTests.Pages;

using NUnit.Framework;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace DemoQAInteractionTests
{
    [TestFixture]
    public class SortableTests
    {
        private ChromeDriver _driver;
        private SortablePage _sortablePage;

        [SetUp]
        public void Init()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _sortablePage = new SortablePage(_driver, 2);
        }

        [Test]
        public void SortableItem1()
        {
            // Arrange
            _sortablePage.Navigate(_sortablePage.Url);

            // Act
            var sortable = _sortablePage.SortableElement1;

            var draggableLocationX = sortable.Location.X;
            var draggableLocationY = sortable.Location.Y;

            var moveX = 0;
            var moveY = sortable.Size.Height + 15;
            var actions = new Actions(_driver);

            actions.ClickAndHold(sortable);
            actions.MoveByOffset(moveX, moveY);
            actions.Release(sortable);
            actions.Perform();

            // Assert
            Assert.AreEqual(draggableLocationX + moveX, sortable.Location.X);
            Assert.AreEqual(draggableLocationY + moveY - 12, sortable.Location.Y, 2);
        }

        [Test]
        public void SortableItem2()
        {
            // Arrange
            _sortablePage.Navigate(_sortablePage.Url);

            // Act
            var sortable = _sortablePage.SortableElement2;

            var draggableLocationX = sortable.Location.X;
            var draggableLocationY = sortable.Location.Y;

            var moveX = 0;
            var moveY = sortable.Size.Height + 15;
            var actions = new Actions(_driver);

            actions.ClickAndHold(sortable);
            actions.MoveByOffset(moveX, moveY);
            actions.Release(sortable);
            actions.Perform();

            // Assert
            Assert.AreEqual(draggableLocationX + moveX, sortable.Location.X);
            Assert.AreEqual(draggableLocationY + moveY - 12, sortable.Location.Y, 2);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}