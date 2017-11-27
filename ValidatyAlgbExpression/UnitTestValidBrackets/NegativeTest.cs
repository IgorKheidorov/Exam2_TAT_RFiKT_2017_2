using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidBrackets;

namespace UnitTestProject1
{
  [TestClass]
  public class NegativeTest
  {
    [TestMethod]
    public void TestEmptyString()
    {
      String expression = "";
      ValidatorAlgebraicExpression validatorAlgebraicExpression = new ValidatorAlgebraicExpression();
      Assert.AreEqual(false, (validatorAlgebraicExpression.CheckExpressionOnValidity(expression)));
    }

    [TestMethod]
    public void TestOnFirstCloseBracket()
    {
      String expression = "){([])}";
      ValidatorAlgebraicExpression validatorAlgebraicExpression = new ValidatorAlgebraicExpression();
      Assert.AreEqual(false, (validatorAlgebraicExpression.CheckExpressionOnValidity(expression)));
    }

    [TestMethod]
    public void TestOnJustOpenBracket()
    {
      String expression = "({([])}";
      ValidatorAlgebraicExpression validatorAlgebraicExpression = new ValidatorAlgebraicExpression();
      Assert.AreEqual(false, (validatorAlgebraicExpression.CheckExpressionOnValidity(expression)));
    }

    [TestMethod]
    public void TestOnTwoOpenBrackets()
    {
      String expression = "((";
      ValidatorAlgebraicExpression validatorAlgebraicExpression = new ValidatorAlgebraicExpression();
      Assert.AreEqual(false, (validatorAlgebraicExpression.CheckExpressionOnValidity(expression)));
    }

    [TestMethod]
    public void TestOnTwoClosedBrackets()
    {
      String expression = ")}";
      ValidatorAlgebraicExpression validatorAlgebraicExpression = new ValidatorAlgebraicExpression();
      Assert.AreEqual(false, (validatorAlgebraicExpression.CheckExpressionOnValidity(expression)));
    }

    [TestMethod]
    public void TestOnOneBracket()
    {
      String expression = "(";
      ValidatorAlgebraicExpression validatorAlgebraicExpression = new ValidatorAlgebraicExpression();
      Assert.AreEqual(false, (validatorAlgebraicExpression.CheckExpressionOnValidity(expression)));
    }
  }
}
