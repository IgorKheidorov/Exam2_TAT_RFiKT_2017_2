using System;
using MyStack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
  [TestClass]
  public class ExceptionTests
  {
    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void TestExceptionOnEmptyStack()
    {
      new StackOnList<int>().Pop();
    }

    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void TestExceptionOnEmptyStack2()
    {
      new StackOnList<int>().Peek();
    }
  }
}
