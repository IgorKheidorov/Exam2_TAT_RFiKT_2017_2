using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackImplementation;
namespace Tests
{
  [TestClass]
  public class ExceptionTests
  {
    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void TestPeekFromEmptyStack()
    {
      MyStack<int> stack = new MyStack<int>();
      stack.Peek();
    }
    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void TestPopFromEmptyStack()
    {
      MyStack<int> stack = new MyStack<int>();
      stack.Pop();
    }
  }
}
