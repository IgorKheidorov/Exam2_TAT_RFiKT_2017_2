using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_3.Tests
{
  [TestClass]
  public class TestsForComplexNumber
  {

    ComplexNumber firstNumber = new ComplexNumber(4.5, 3.0);
    ComplexNumber secondNumber = new ComplexNumber(1.1, 0.5);

    [TestMethod]
    public void PositiveResultAddition()
    {
      new ComplexNumber().Equals(new ComplexNumber(5.6, 3.5), new ComplexNumber().SumComplexNumber(firstNumber, secondNumber));
    }

    [TestMethod]
    public void PositiveResultSubtract()
    {
      new ComplexNumber().Equals(new ComplexNumber(3.4, 2.5), new ComplexNumber().SubtractComplexNumber(firstNumber, secondNumber));
    }

    [TestMethod]
    public void PositiveResultMultiplication()
    {
      new ComplexNumber().Equals(new ComplexNumber(3.45, 5.55), new ComplexNumber().MultiplicationComplexNumber(firstNumber, secondNumber));
    }
  }
}
