using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using Lagrange2;

namespace LagrangeTests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            var Lag = new Lagrange();

            const int size = 5;
            var xValues = new double[size];
            var yValues = new double[size];
            xValues[0] = -5; yValues[0] = 25;
            xValues[1] = -3; yValues[1] = 9;
            xValues[2] = 0; yValues[2] = 0;
            xValues[3] = 3; yValues[3] = 9;
            xValues[4] = 5; yValues[4] = 25;

            double expected = 1;

            double result = Lagrange.InterpolateLagrangePolynomial(1, xValues, yValues, 5);
            Assert.AreEqual(expected, result);
        }
    }
}
