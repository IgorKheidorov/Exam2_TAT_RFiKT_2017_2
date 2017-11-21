using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_1.Tests
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Assert.IsTrue(123 == new StringToIntConverter().ConvertStringToInt("123"));
      Assert.IsTrue(-123 == new StringToIntConverter().ConvertStringToInt("-123"));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestMethod2()
    {
      Assert.IsTrue(123 == new StringToIntConverter().ConvertStringToInt(""));
      Assert.IsTrue(-123 == new StringToIntConverter().ConvertStringToInt("sdf"));
    }
  }
}
