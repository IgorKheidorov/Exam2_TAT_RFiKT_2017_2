using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckParentheses;

namespace UnitTest
{
  [TestClass]
  public class UnitTestPositive
  {
    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void TestExeptionForNullString()
    {
      new CheckerOfParentheses("");
    }

    [TestMethod]
    public void TestValideString()
    {
      Assert.AreEqual(true,new CheckerOfParentheses("((()))").CheckerSequence());
    }
  }
}
