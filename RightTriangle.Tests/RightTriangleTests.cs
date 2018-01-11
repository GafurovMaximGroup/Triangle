using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RightTriangle.Tests
{
    [TestClass]
    public class RightTriangleTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int katetA = 15;
            int katetB = 20;
            int expected_area = 150;

            Triangle.RightTriangle rightTriangle = new Triangle.RightTriangle();
            int actual_area = rightTriangle.CalculationArea(15, 20, 35);
            Assert.AreEqual(expected_area, actual_area);
        }
    }
}
