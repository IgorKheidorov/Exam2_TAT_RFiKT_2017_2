using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbers;
namespace Tests
{
  [TestClass]
  public class Tests
  {
    [TestMethod]
    public void TestAddition()
    {
      Assert.AreEqual("9+12i", (new ComplexNumber(5, 7) + new ComplexNumber(4, 5)).ToString());
    }
    [TestMethod]
    public void TestMultiplication()
    {
      Assert.AreEqual("-150+200i", (new ComplexNumber(5, 10) * new ComplexNumber(10, 20)).ToString());
    }
    [TestMethod]
    public void TestDivision()
    {
      Assert.AreEqual("2", (new ComplexNumber(20,4) / new ComplexNumber(10, 2)).ToString());
    }
    [TestMethod]
    public void TestSubtraction()
    {
      Assert.AreEqual("15+6i", (new ComplexNumber(27, 19) - new ComplexNumber(12, 13)).ToString());
    }
  }
}
