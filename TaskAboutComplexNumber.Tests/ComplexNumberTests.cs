using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskAboutComplexNumber.Tests
{
    [TestClass]
    public class ComplexNumberTests
    {
        [TestMethod]
        public void TestAdditionPositive()
        {
            ComplexNumber excpectedResultOfAddition = new ComplexNumber(3, 5);
            ComplexNumber firstComplexNumber = new ComplexNumber(2, 3);
            ComplexNumber secondComplexNumber = new ComplexNumber(1, 2);
            ComplexNumber resultOfAddition = firstComplexNumber + secondComplexNumber;
            Assert.AreEqual(excpectedResultOfAddition, resultOfAddition);
        }

        [TestMethod]
        public void TestSubstructionPositive()
        {
            ComplexNumber excpectedResult = new ComplexNumber(2, 1);
            ComplexNumber firstComplexNumber = new ComplexNumber(3, 5);
            ComplexNumber secondComplexNumber = new ComplexNumber(1, 4);
            ComplexNumber result = firstComplexNumber - secondComplexNumber;
            Assert.AreEqual(excpectedResult, result);
        }

        [TestMethod]
        public void TestDivisionNegative()
        {
            ComplexNumber excpectedResult = new ComplexNumber(1, -1);
            ComplexNumber firstComplexNumber = new ComplexNumber(1, 1);
            ComplexNumber secondComplexNumber = new ComplexNumber(2, 1);
            ComplexNumber result = firstComplexNumber / secondComplexNumber;
            Assert.AreNotEqual(excpectedResult, result);
        }

        [TestMethod]
        public void TestDivisionZeroAndSomething()
        {
            ComplexNumber excpectedResult = new ComplexNumber(0, 0);
            ComplexNumber firstComplexNumber = new ComplexNumber(0, 0);
            ComplexNumber secondComplexNumber = new ComplexNumber(2, 1);
            ComplexNumber result = firstComplexNumber / secondComplexNumber;
            Assert.AreEqual(excpectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionByZero()
        {
            ComplexNumber firstComplexNumber = new ComplexNumber(2, 1);
            ComplexNumber secondComplexNumber = new ComplexNumber(0, 0);
            ComplexNumber result = firstComplexNumber / secondComplexNumber;          
        }

        [TestMethod]
        public void TestMultiplicationPositive()
        {
            ComplexNumber excpectedResult = new ComplexNumber(-2, 6);
            ComplexNumber firstComplexNumber = new ComplexNumber(1, 2);
            ComplexNumber secondComplexNumber = new ComplexNumber(2, 2);
            ComplexNumber result = firstComplexNumber * secondComplexNumber;
            Assert.AreEqual(excpectedResult, result);
        }

        [TestMethod]
        public void TestMultiplicationNegative()
        {
            ComplexNumber excpectedResult = new ComplexNumber(-3, 5);
            ComplexNumber firstComplexNumber = new ComplexNumber(1, 2);
            ComplexNumber secondComplexNumber = new ComplexNumber(2, 2);
            ComplexNumber result = firstComplexNumber * secondComplexNumber;
            Assert.AreNotEqual(excpectedResult, result);
        }

        [TestMethod]
        public void TestCompareToOnSameComplexNumbers()
        {
            ComplexNumber firstComplexNumber = new ComplexNumber(-2, 6);
            ComplexNumber secondComplexNumber = new ComplexNumber(-2, 6);
            Assert.IsTrue(firstComplexNumber.CompareTo(secondComplexNumber) == 0);
        }

        [TestMethod]
        public void TestCompareToOnDifferentInCorrectOrderComplexNumbers()
        {
            ComplexNumber firstComplexNumber = new ComplexNumber(-2, 1);
            ComplexNumber secondComplexNumber = new ComplexNumber(1, 3);
            Assert.IsTrue(firstComplexNumber.CompareTo(secondComplexNumber) < 0);
        }

        [TestMethod]
        public void TestAbs()
        {
            ComplexNumber firstComplexNumber = new ComplexNumber(2, 4);
            double excpectedResult = Math.Sqrt(Math.Pow(2, 2) + Math.Pow(4, 2));          
            Assert.AreEqual(excpectedResult, firstComplexNumber.Abs());
        }

        [TestMethod]
        public void TestAbsOnZero()
        {
            ComplexNumber firstComplexNumber = new ComplexNumber(0, 0);
            double excpectedResult = Math.Sqrt(Math.Pow(0, 2) + Math.Pow(0, 2));
            Assert.AreEqual(excpectedResult, firstComplexNumber.Abs());
        }

        [TestMethod]
        public void TestAbsOnNegative()
        {
            ComplexNumber firstComplexNumber = new ComplexNumber(-2, -4);
            double excpectedResult = Math.Sqrt(Math.Pow(-2, 2) + Math.Pow(-4, 2));
            Assert.AreEqual(excpectedResult, firstComplexNumber.Abs());
        }
    }
}
