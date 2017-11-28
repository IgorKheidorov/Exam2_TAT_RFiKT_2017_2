using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbers;

namespace UnitTestOnComplexNumbers
{
  [TestClass]
  public class PositiveTests
  {
    [TestMethod]
    public void FirstNumberMoreThanSecond()
    {
      ComplexNumber firstNumber = new ComplexNumber(8.0, 2.0);
      ComplexNumber secondNumber = new ComplexNumber(1.0, 9.0);
      Assert.AreEqual(-1, firstNumber.Compare(secondNumber));
    }

    [TestMethod]
    public void SumFirstWithSecond()
    {
      ComplexNumber firstNumber = new ComplexNumber(8.0, 2.0);
      ComplexNumber secondNumber = new ComplexNumber(1.0, 9.0);
      Assert.AreEqual("9+11i" , new ComplexNumber().Sum(firstNumber,secondNumber).ToString());
    }

    [TestMethod]
    public void MultiplicationFirstOnSecond()
    {
      ComplexNumber firstNumber = new ComplexNumber(5.0, 10.0);
      ComplexNumber secondNumber = new ComplexNumber(2.0, 4.0);
      Assert.AreEqual("10+40i", new ComplexNumber().Multiplication(firstNumber, secondNumber).ToString());
    }

    [TestMethod]
    public void SubstractFirstOnSecond()
    {
      ComplexNumber firstNumber = new ComplexNumber(5.0, 10.0);
      ComplexNumber secondNumber = new ComplexNumber(2.0, 4.0);
      Assert.AreEqual("3+6i", new ComplexNumber().Subtract(firstNumber, secondNumber).ToString());
    }

    [TestMethod]
    public void FirstMoreThanSecond()
    {
      ComplexNumber firstNumber = new ComplexNumber(5.0, 10.0);
      ComplexNumber secondNumber = new ComplexNumber(2.0, 4.0);
      Assert.AreEqual(1, firstNumber.Compare(secondNumber));
    }

    [TestMethod]
    public void TestOnSimpleConstructor()
    {
      ComplexNumber firstNumber = new ComplexNumber();
      Assert.AreEqual(0, firstNumber.GetRe());
      Assert.AreEqual(0, firstNumber.GetIm());
    }

    [TestMethod]
    public void TestOnConstructorCopy()
    {
      ComplexNumber firstNumber = new ComplexNumber(5.0, 10.0);
      ComplexNumber secondNumber = new ComplexNumber(firstNumber);
      Assert.AreEqual(5, secondNumber.GetRe());
      Assert.AreEqual(10, secondNumber.GetIm());
    }

    [TestMethod]
    public void TestOnConstructorWithParam()
    {
      ComplexNumber firstNumber = new ComplexNumber(5.0, 10.0);
      Assert.AreEqual(5, firstNumber.GetRe());
      Assert.AreEqual(10, firstNumber.GetIm());
    }

    [TestMethod]
    public void TestOnSymbolSum()
    {
      ComplexNumber firstNumber = new ComplexNumber(5.0, 10.0);
      ComplexNumber secondNumber = new ComplexNumber(8, 16);
      Assert.AreEqual("13+26i", (firstNumber+secondNumber).ToString());
    }
  }
}
