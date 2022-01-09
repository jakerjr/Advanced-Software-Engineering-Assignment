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

    }
}