using System;
using CheckParentheses;

namespace UnitTest
{
  class UnitTestNegative
  {
    [TestMethod]
    public void TestInValideString()
    {
      Assert.AreEqual(false, new CheckerOfParentheses("((()]))").CheckerSequence());
    }
  }
}
