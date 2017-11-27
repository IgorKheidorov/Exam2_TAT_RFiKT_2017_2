using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brackets;
namespace UnitTestProject1
{
  [TestClass]
  public class NegativeTests
  {
    [TestMethod]
    public void TestExpressionWithOneBracket()
    {
      Assert.AreEqual(false, new BracketsValidator("{").ValidateExpression());
    }
    [TestMethod]
    public void TestEmptyExpression()
    {
      Assert.AreEqual(false, new BracketsValidator(String.Empty).ValidateExpression());
    }
    [TestMethod]
    public void TestExpressionWithWrongNumberOfOpenBrackets()
    {
      Assert.AreEqual(false, new BracketsValidator("{{}").ValidateExpression());
    }
    [TestMethod]
    public void TestExpressionWithWrongNumberOfCloseBrackets()
    {
      Assert.AreEqual(false, new BracketsValidator("{}}").ValidateExpression());
    }
  }
}