using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace UnitTestTask3
{
    [TestClass]
    public class TestComplexNumber
    {
        [TestMethod]
        public void TestCalculateSum()
        {
            ComplexNumber first = new ComplexNumber(5, 4);
            ComplexNumber second = new ComplexNumber(4, -3);

            ComplexNumber expect = new ComplexNumber(9, 1);
            ComplexNumber real = new ComplexNumber().CalculateSum(first, second);

            Assert.AreEqual(true, expect.Re.Equals(real.Re));
            Assert.AreEqual(true, expect.Im.Equals(real.Im));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCalculateSumMoreThanMaxValueOfDouble()
        {
            ComplexNumber first = new ComplexNumber(double.MaxValue, 4);
            ComplexNumber second = new ComplexNumber(4, -3);
            ComplexNumber result = new ComplexNumber().CalculateSum(first, second);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCalculateSumLessThanMinValueOfDouble()
        {
            ComplexNumber first = new ComplexNumber(double.MinValue, 4);
            ComplexNumber second = new ComplexNumber(-10, -3);

            ComplexNumber result = new ComplexNumber().CalculateSum(first, second);
        }

        [TestMethod]
        public void TestCalculateDifference()
        {
            ComplexNumber first = new ComplexNumber(5, 4);
            ComplexNumber second = new ComplexNumber(4, -3);

            ComplexNumber expect = new ComplexNumber(1, 7);
            ComplexNumber real = new ComplexNumber().CalculateDifference(first, second);

            Assert.AreEqual(true, expect.Re.Equals(real.Re));
            Assert.AreEqual(true, expect.Im.Equals(real.Im));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCalculateDifferenceMoreThanMaxValueOfDouble()
        {
            ComplexNumber first = new ComplexNumber(-3, 4);
            ComplexNumber second = new ComplexNumber(double.MaxValue, -3);

            ComplexNumber result = new ComplexNumber().CalculateDifference(first, second);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCalculateDifferenceLessThanMinValueOfDouble()
        {
            ComplexNumber first = new ComplexNumber(double.MinValue, 4);
            ComplexNumber second = new ComplexNumber(10, -3);

            ComplexNumber real = new ComplexNumber().CalculateDifference(first, second);
        }

        [TestMethod]
        public void TestMultiply()
        {
            ComplexNumber first = new ComplexNumber(1, 1);
            ComplexNumber second = new ComplexNumber(1, 1);

            ComplexNumber expect = new ComplexNumber(0, 2);
            ComplexNumber real = new ComplexNumber().Multiply(first, second);

            Assert.AreEqual(true, expect.Re.Equals(real.Re));
            Assert.AreEqual(true, expect.Im.Equals(real.Im));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMultiplyMoreThanMaxValueOfDouble()
        {
            ComplexNumber first = new ComplexNumber(3, 4);
            ComplexNumber second = new ComplexNumber(double.MaxValue, -3);

            ComplexNumber result = new ComplexNumber().Multiply(first, second);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMultiplyLessThanMinValueOfDouble()
        {
            ComplexNumber first = new ComplexNumber(double.MinValue, 4);
            ComplexNumber second = new ComplexNumber(10, -3);

            ComplexNumber real = new ComplexNumber().Multiply(first, second);
        }

        [TestMethod]
        public void TestDivide()
        {
            ComplexNumber first = new ComplexNumber(1, 1);
            ComplexNumber second = new ComplexNumber(1, 1);

            ComplexNumber expect = new ComplexNumber(1, 0);
            ComplexNumber real = new ComplexNumber().Divide(first, second);

            Assert.AreEqual(true, expect.Re.Equals(real.Re));
            Assert.AreEqual(true, expect.Im.Equals(real.Im));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDivideMoreThanMaxValueOfDouble()
        {
            ComplexNumber first = new ComplexNumber(3, 4);
            ComplexNumber second = new ComplexNumber(double.MaxValue, -3);

            ComplexNumber result = new ComplexNumber().Divide(first, second);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDivideLessThanMinValueOfDouble()
        {
            ComplexNumber first = new ComplexNumber(double.MinValue, 4);
            ComplexNumber second = new ComplexNumber(10, -3);

            ComplexNumber real = new ComplexNumber().Divide(first, second);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDivideToZero()
        {
            ComplexNumber first = new ComplexNumber(double.MinValue, 4);
            ComplexNumber second = new ComplexNumber(0, 0);

            ComplexNumber real = new ComplexNumber().Divide(first, second);
        }
    }
}