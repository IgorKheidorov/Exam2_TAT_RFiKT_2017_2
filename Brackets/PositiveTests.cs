using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brackets;
namespace UnitTestProject1
{
  [TestClass]
  public class PositiveTests
  {
    [TestMethod]
    public void TestIfExpressionWithDifferentBracketsIsValid()
    {
      Assert.AreEqual(true,new BracketsValidator("{[()]}").ValidateExpression());
    }
    [TestMethod]
    public void TestIfExpressionWithSameBracketsIsValid()
    {
      Assert.AreEqual(true, new BracketsValidator("(())").ValidateExpression());
    }
    [TestMethod]
    public void TestIfAlgebraicExpressionIsValid()
    {
      Assert.AreEqual(true, new BracketsValidator("(5+10[18]+(3-4))").ValidateExpression());
    }
    [TestMethod]
    public void TestIfBracketsGetterWorksCorrect()
    {
      Assert.AreEqual("([])", new BracketsGetter("(5+10[18+12]+3-4)").GetBrackets());
    }
  }
}
