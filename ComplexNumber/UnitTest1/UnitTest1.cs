using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActionsWithComplexNumber;

namespace UnitTest1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestSumOfNumbers()
    {
      Assert.AreEqual(new ComplexNumber(5, 8).ToString(), new ComplexNumber().CalculateSumOfNumbers(new ComplexNumber(2, 3), new ComplexNumber(3, 4)).ToString());
    }

    [TestMethod]
    public void TestSumOfNumbers2()
    {
      Assert.AreEqual(new ComplexNumber(7, 7).ToString(), new ComplexNumber().CalculateSumOfNumbers(new ComplexNumber(4, 5), new ComplexNumber(3, 4)).ToString());
    }

    [TestMethod]
    public void TestDifferenceOfNumbers()
    {
      Assert.AreEqual(new ComplexNumber(1, 1).ToString(), new ComplexNumber().CalculateDifferenceOfNumbers(new ComplexNumber(4, 5), new ComplexNumber(3, 4)).ToString());
    }

    [TestMethod]
    public void TestDifferenceOfNumbers2()
    {
      Assert.AreEqual(new ComplexNumber(2, 1).ToString(), new ComplexNumber().CalculateDifferenceOfNumbers(new ComplexNumber(6, 5), new ComplexNumber(2, 4)).ToString());
    }

    [TestMethod]
    public void TestDifferenceOfNumbers3()
    {
      Assert.AreEqual(new ComplexNumber(1, 1).ToString(), new ComplexNumber().CalculateDifferenceOfNumbers(new ComplexNumber(4, 5), new ComplexNumber(3, 4)).ToString());
    }

    [TestMethod]
    public void TestDivideOfNumbers()
    {
      Assert.AreEqual(new ComplexNumber(-3/2, -1/2).ToString(), new ComplexNumber().CalculateDivideOfNumbers(new ComplexNumber(-2, 1), new ComplexNumber(1, - 1)).ToString());
    }

    [TestMethod]
    public void TestCompareOfNumbers()
    {
      Assert.AreEqual(0.ToString(), new ComplexNumber().ComparisonOfNumbers(new ComplexNumber(-2, 1), new ComplexNumber(1, -1)).ToString());
    }
  }
}
