using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System.Drawing;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateImage_ValidWidthAndHeight_ReturnsBitmap()
        {
            // Arrange
            Autorize authForm = new Autorize();

            // Act
            Bitmap image = authForm.CreateImage(100, 50);

            // Assert
            Assert.IsNotNull(image);
            Assert.AreEqual(100, image.Width);
            Assert.AreEqual(50, image.Height);

        }
    }
}
