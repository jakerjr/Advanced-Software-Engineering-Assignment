using Assessment1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AssessmentTest
{
    [TestClass]
    public class AssessmentTests
    {
        /// <summary>
        /// This test i used to check wheather the Circle class is giving the correct output.
        /// </summary>
        [TestMethod]
        public void TestCircleDraw()
        {
            // A cricle class is defined to calculate the numbers.
            Circle circleTest = new Circle(0, 0, 50);

            // Expected results and chcking are appended.
            Assert.AreEqual(-25, circleTest.xPosition);
            Assert.AreEqual(-25, circleTest.yPosition);
            Assert.AreEqual(50, circleTest.rad);
        }

        [TestMethod]
        public void TestDrawRect()
        {
            
            Rectangle rectangleTest = new Rectangle(100, 100, 300, 300);

            Assert.AreEqual(100, rectangleTest.xPosition);
            Assert.AreEqual(400, rectangleTest.toX);
            Assert.AreEqual(100, rectangleTest.yPosition);
            Assert.AreEqual(400, rectangleTest.toY);
        }

        [TestMethod]
        public void TestDrawTriangle()
        {
            Triangle triangleTest = new Triangle(100, 100, 100);

            Assert.AreEqual(100, triangleTest.length);
            Assert.AreEqual(100, triangleTest.xPos);
            Assert.AreEqual(100, triangleTest.yPos);
        }
    }
}