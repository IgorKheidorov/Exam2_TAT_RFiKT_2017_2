using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_3.Task_5.Tests
{
  [TestClass]
  public class TestsForStack
  {
    [TestMethod]
    public void PositiveTestPush()
    {
      MyStack<string> stack = new MyStack<string>();
      stack.Push("123");
      Assert.AreEqual(1, stack.Count);
    }

    [TestMethod]
    public void NegativeTestPush()
    {
      MyStack<string> stack = new MyStack<string>();
      stack.Push("123");
      Assert.AreNotEqual(0, stack.Count);
    }

    [TestMethod]
    public void PositiveTestPeek()
    {
      MyStack<string> stack = new MyStack<string>();
      stack.Push("123");
      stack.Push("abc");
      Assert.AreEqual("abc", stack.Peek());
    }

    [TestMethod]
    public void NegativeTestPeek()
    {
      MyStack<string> stack = new MyStack<string>();
      stack.Push("123");
      stack.Push("abc");
      Assert.AreNotEqual("123", stack.Peek());
    }

    [TestMethod]
    public void PositiveTestPop()
    {
      MyStack<string> stack = new MyStack<string>();
      stack.Push("123");
      stack.Push("abc");
      Assert.AreEqual("abc", stack.Pop());
      Assert.AreEqual(1, stack.Count);
    }

    [TestMethod]
    public void NegativeTestPop()
    {
      MyStack<string> stack = new MyStack<string>();
      stack.Push("123");
      stack.Push("abc");
      Assert.AreEqual("abc", stack.Pop());
      Assert.AreNotEqual(2, stack.Count);
    }

    [TestMethod]
    public void TestClear()
    {
      MyStack<string> firstStack = new MyStack<string>();
      firstStack.Push("123");
      firstStack.Push("abc");
      Assert.AreEqual(0, firstStack.Count);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestException()
    {
      new MyStack<string>().Peek();
      new MyStack<string>().Pop();
    }
  }
}
