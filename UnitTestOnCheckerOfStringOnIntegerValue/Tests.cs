using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckOnIntegerInputString;

namespace CheckOnIntegerInputString
{
  [TestClass]
  public class Tests
  {
    [TestMethod]
    public void TestOnPositiveResult()
    {
      Assert.AreEqual(true, new CheckerOnIntegerInputData("12354586").CheckOnIntegerInputData());
    }

    [TestMethod]
    public void TestOnNegativeResult()
    {
      Assert.AreEqual(false, new CheckerOnIntegerInputData("1235erc 4586").CheckOnIntegerInputData());
    }
  }
}
