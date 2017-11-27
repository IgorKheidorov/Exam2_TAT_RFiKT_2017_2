using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_3.Task_2.Tests
{
  [TestClass]
  public class TestsForValidator
  {
    [TestMethod]
    public void Positive()
    {
      Assert.AreEqual(true, new BracketsValidator().CheckBracketsAlignment("()"));
      Assert.AreEqual(true, new BracketsValidator().CheckBracketsAlignment("[]"));
      Assert.AreEqual(true, new BracketsValidator().CheckBracketsAlignment("{}"));
      Assert.AreEqual(true, new BracketsValidator().CheckBracketsAlignment("([{}])"));
      Assert.AreEqual(true, new BracketsValidator().CheckBracketsAlignment("{{{}}}"));
    }

    [TestMethod]
    public void Negative()
    {
      Assert.AreEqual(false, new BracketsValidator().CheckBracketsAlignment("(]"));
      Assert.AreEqual(false, new BracketsValidator().CheckBracketsAlignment("(()"));
      Assert.AreEqual(false, new BracketsValidator().CheckBracketsAlignment("({)}"));
      Assert.AreEqual(false, new BracketsValidator().CheckBracketsAlignment("("));
      Assert.AreEqual(false, new BracketsValidator().CheckBracketsAlignment("}"));
    }
  }
}
