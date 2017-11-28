using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskComplexNumber;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethodSum()
    {      
      Assert.AreEqual(new ComplexNumber(6.6,6.6).ToString(), new ComplexNumber().AddUp(new ComplexNumber(2.3, 3.2), new ComplexNumber(4.3, 3.4)));
    }

    [TestMethod]
    public void TestMethodDeduct()
    {
      Assert.AreEqual(new ComplexNumber(1, 0), new ComplexNumber().Deduct(new ComplexNumber(5, 3), new ComplexNumber(4, 3)));
    }
  }
}
