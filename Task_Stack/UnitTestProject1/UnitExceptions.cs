using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskStack;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitExceptions
  {
    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestExceptionPop()
    {
      NodeStack<int> nodeStack = new NodeStack<int>();
      new NodeStack<int>().Pop();
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestExceptionPeek()
    {
      NodeStack<int> nodeStack = new NodeStack<int>();
      new NodeStack<int>().Peek();
    }
  }
}