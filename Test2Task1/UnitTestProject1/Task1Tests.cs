using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test2Task1;
namespace UnitTestProject1
{
  [TestClass]
  public class Task1Tests
  {
    [TestMethod]
    public void TestPositiveValue()
    {
      Assert.AreEqual(12345,new IntegerParser("12345").ConvertToInt());
    }
    [TestMethod]
    public void TestNegativeValue()
    {
      Assert.AreEqual(-12345, new IntegerParser("-12345").ConvertToInt());
    }

  }
}
