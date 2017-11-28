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
      new ComplexNumber().Equals(new ComplexNumber(1, 2), new ComplexNumber().FoldComplexNumbers(new ComplexNumber(0.5, 1.1), new ComplexNumber(0.5, 0.9)));
    }

    [TestMethod]
    public void PositiveResulMultiplication()
    {
      new ComplexNumber().Equals(new ComplexNumber(0.74, 1), new ComplexNumber().MultiplyComplexNumbers(new ComplexNumber(0.5, 1.1), new ComplexNumber(0.5, 0.9)));
      new ComplexNumber().Equals(new ComplexNumber(0, 0), new ComplexNumber().MultiplyComplexNumbers(new ComplexNumber(0.5, 1.1), new ComplexNumber(0, 0)));
    }

    [TestMethod]
    public void MaxBorderDouble()
    {
      new ComplexNumber().Equals(new ComplexNumber(Double.MaxValue, 0), new ComplexNumber().MultiplyComplexNumbers(new ComplexNumber(Double.MaxValue, 0), new ComplexNumber(1, 0)));
      new ComplexNumber().Equals(new ComplexNumber(Double.MaxValue, 0), new ComplexNumber().FoldComplexNumbers(new ComplexNumber(Double.MaxValue, 0), new ComplexNumber(0, 0)));
    }

    [TestMethod]
    public void MinBorderDouble()
    {
      new ComplexNumber().Equals(new ComplexNumber(Double.MinValue, 0), new ComplexNumber().MultiplyComplexNumbers(new ComplexNumber(Double.MinValue, 0), new ComplexNumber(1, 0)));
      new ComplexNumber().Equals(new ComplexNumber(Double.MinValue, 0), new ComplexNumber().FoldComplexNumbers(new ComplexNumber(Double.MinValue, 0), new ComplexNumber(0, 0)));
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
