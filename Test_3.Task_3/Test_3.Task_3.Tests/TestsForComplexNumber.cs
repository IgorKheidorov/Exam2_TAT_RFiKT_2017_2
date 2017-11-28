using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_3.Task_3.Tests
{
  [TestClass]
  public class TestsForComplexNumber
  {
    [TestMethod]
    public void PositiveResulAddition()
    {
      Assert.AreEqual(new ComplexNumber(1, 2), new ComplexNumber().FoldComplexNumbers(new ComplexNumber(0.5, 1.1), new ComplexNumber(0.5, 0.9)));
    }

    [TestMethod]
    public void PositiveResulMultiplication()
    {
      Assert.AreEqual(new ComplexNumber(0.74, 1), new ComplexNumber().MultiplyComplexNumbers(new ComplexNumber(0.5, 1.1), new ComplexNumber(0.5, 0.9)));
      Assert.AreEqual(new ComplexNumber(0, 0), new ComplexNumber().MultiplyComplexNumbers(new ComplexNumber(0.5, 1.1), new ComplexNumber(0, 0)));
    }

    [TestMethod]
    public void MaxBorderDouble()
    {
      Assert.AreEqual(new ComplexNumber(Double.MaxValue, 0), new ComplexNumber().MultiplyComplexNumbers(new ComplexNumber(Double.MaxValue, 0), new ComplexNumber(1, 0)));
      Assert.AreEqual(new ComplexNumber(Double.MaxValue, 0), new ComplexNumber().FoldComplexNumbers(new ComplexNumber(Double.MaxValue, 0), new ComplexNumber(0, 0)));
    }

    [TestMethod]
    public void MinBorderDouble()
    {
      Assert.AreEqual(new ComplexNumber(Double.MinValue, 0), new ComplexNumber().MultiplyComplexNumbers(new ComplexNumber(Double.MinValue, 0), new ComplexNumber(1, 0)));
      Assert.AreEqual(new ComplexNumber(Double.MinValue, 0), new ComplexNumber().FoldComplexNumbers(new ComplexNumber(Double.MinValue, 0), new ComplexNumber(0, 0)));
    }

    [TestMethod]
    [ExpectedException(typeof(FormatException))]
    public void MoreMaxBorderDouble()
    {
      new ComplexNumber().MultiplyComplexNumbers(new ComplexNumber(Double.MaxValue, 0), new ComplexNumber(2, 2));
      new ComplexNumber().FoldComplexNumbers(new ComplexNumber(Double.MaxValue, 0), new ComplexNumber(2, 0));
    }

    [TestMethod]
    [ExpectedException(typeof(FormatException))]
    public void MoreMinBorderDouble()
    {
      new ComplexNumber().MultiplyComplexNumbers(new ComplexNumber(Double.MinValue, 0), new ComplexNumber(2, 2));
      new ComplexNumber().FoldComplexNumbers(new ComplexNumber(Double.MinValue, 0), new ComplexNumber(2, 0));
    }
  }
}
