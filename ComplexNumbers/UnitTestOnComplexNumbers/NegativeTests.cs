using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbers;

namespace UnitTestOnComplexNumbers
{
  [TestClass]
  public class NegativeTests
  {
    [TestMethod]
    public void FirstNumberMoreThanSecond()
    {
      ComplexNumber firstNumber = new ComplexNumber(1.0, 2.0);
      ComplexNumber secondNumber = new ComplexNumber(1.0, 9.0);
      Assert.AreEqual(true, firstNumber.Compare(secondNumber) == -1);
    }

    [TestMethod]
    public void DivisionFirstOnSecond()
    {
      ComplexNumber firstNumber = new ComplexNumber(5.0, 10.0);
      ComplexNumber secondNumber = new ComplexNumber(2.0, 4.0);
      Assert.AreEqual(false, new ComplexNumber().Sum(firstNumber, secondNumber).ToString().Equals("5+10i"));
    }

    [TestMethod]
    public void TestOnUncorrectSum()
    {
      ComplexNumber firstNumber = new ComplexNumber(5.0, 10.0);
      ComplexNumber secondNumber = new ComplexNumber(8, 16);
      Assert.AreEqual(false, (firstNumber + secondNumber).ToString().Equals("3+26i"));
    }

  }
}
