using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgebraicExpression.Tests
{
  [TestClass]
  public class BracketsChackerTests
  {
    [TestMethod]
    public void CheckBrackets_expressionWithBrackets_trueValue()
    {
      Assert.AreEqual(true, new Expression("()[]").GetBrackets());
    }

    [TestMethod]
    public void CheckBrackets_emptyExpression_trueValue()
    {
      Assert.AreEqual(true, new Expression(" ").GetBrackets());
    }

    [TestMethod]
    public void CheckBrackets_wrongExpression_falseValue()
    {
      Assert.AreEqual(false, new Expression("([)]").GetBrackets());
    }
  }
}