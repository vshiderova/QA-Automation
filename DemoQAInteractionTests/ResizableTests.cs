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
    public class ResizableTests
    {
        private ChromeDriver _driver;
        private ResizablePage _resizablePage;

        [SetUp]
        public void Init()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _resizablePage = new ResizablePage(_driver, 2);
        }

        [Test]
        public void ResizeBoxWidthAndHeight()
        {
            // Arrange
            _resizablePage.Navigate(_resizablePage.Url);

            // Act
            var resizableBox = _resizablePage.ResizableElement;

            double expectedWidth = resizableBox.Size.Width + 84;
            double expectedHeight = resizableBox.Size.Height + 84;

            var resizeHadle = _driver.FindElement(By.XPath(@"//*[@id=""resizable""]/div[3]"));

            var builder = new Actions(_driver);
            builder.DragAndDropToOffset(resizeHadle, 100, 100).Perform();

            double actualWidth = resizableBox.Size.Width;
            double actualHeight = resizableBox.Size.Height;

            // Assert
            Assert.AreEqual(expectedHeight, actualHeight, 2);
            Assert.AreEqual(expectedWidth, actualWidth, 2);
        }

        [Test]
        public void RealSizeOfBox()
        {
            // Arrange
            _resizablePage.Navigate(_resizablePage.Url);

            // Act
            var resizableBox = _resizablePage.ResizableElement;

            double actualWidth = resizableBox.Size.Width;
            double actualHeight = resizableBox.Size.Height;

            // Assert
            Assert.AreEqual(150, actualWidth, 2);
            Assert.AreEqual(150, actualHeight, 2);
        }

        [Test]
        public void ResizeBoxHeight()
        {
            // Arrange
            _resizablePage.Navigate(_resizablePage.Url);

            // Act
            var resizableBox = _resizablePage.ResizableElement;

            double expectedWidth = resizableBox.Size.Width;
            double expectedHeight = resizableBox.Size.Height + 34;

            var resizeHadle = _driver.FindElement(By.XPath(@"//*[@id=""resizable""]/div[3]"));

            var builder = new Actions(_driver);
            builder.DragAndDropToOffset(resizeHadle, 0, 50).Perform();

            double actualWidth = resizableBox.Size.Width;
            double actualHeight = resizableBox.Size.Height;

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth, 2);
            Assert.AreEqual(expectedHeight, actualHeight, 2);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
