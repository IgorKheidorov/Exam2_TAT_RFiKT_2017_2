using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidBrackets;

namespace UnitTestProject1
{
  [TestClass]
  public class PositiveTest
  {
    [TestMethod]
    public void TestBracketsWithData()
    {
      String expression = "{1+1([2*2] * 10)}";
      ValidatorAlgebraicExpression validatorAlgebraicExpression = new ValidatorAlgebraicExpression();
      Assert.AreEqual(true, (validatorAlgebraicExpression.CheckExpressionOnValidity(expression)));
    }

    [TestMethod]
    public void TestOnExpressionWhenEmptyBrakets()
    {
      String expression = "{[(256/8)]}";
      ValidatorAlgebraicExpression validatorAlgebraicExpression = new ValidatorAlgebraicExpression();
      Assert.AreEqual(true, (validatorAlgebraicExpression.CheckExpressionOnValidity(expression)));
    }

    [TestMethod]
    public void TestOnFullBracketsWithData()
    {
      String expression = "{1[2(5(28-2)/888)]}";
      ValidatorAlgebraicExpression validatorAlgebraicExpression = new ValidatorAlgebraicExpression();
      Assert.AreEqual(true, (validatorAlgebraicExpression.CheckExpressionOnValidity(expression)));
    }

    [TestMethod]
    public void TestOnMixBrakets()
    {
      String expression = "{([)}]";
      ValidatorAlgebraicExpression validatorAlgebraicExpression = new ValidatorAlgebraicExpression();
      Assert.AreEqual(true, (validatorAlgebraicExpression.CheckExpressionOnValidity(expression)));
    }
  }
}
