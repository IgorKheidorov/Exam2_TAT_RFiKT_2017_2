using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgebraicExpression.Tests
{
  [TestClass]
  public class ExpressionTests
  {
    [TestMethod]
    public void Expression_string_succesfullInit()
    {
      Assert.AreEqual("1+2", new Expression("1+2").InputedExpression);
    }

    [TestMethod]
    public void GetBrackets_expressionWithBrackets_stringWithBrackets()
    {
      Assert.AreEqual("()[]", new Expression("(1+2)-[0]").GetBrackets());
    }
  }
}
