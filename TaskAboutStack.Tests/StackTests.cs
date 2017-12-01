using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskAboutStack.Tests
{
  [TestClass]
  public class StackTests
  {
    [TestMethod]
    public void TestPushOnCount()
    {
      MyStack<string> stack = new MyStack<string>();
      stack.Push("1");
      Assert.IsTrue(stack.count == 1);
    }

    [TestMethod]
    public void TestPeek()
    {
      MyStack<string> stack = new MyStack<string>();
      stack.Push("1");
      Assert.AreEqual("1", stack.Peek());
      Assert.IsTrue(stack.count == 1);
    }

    [TestMethod]
    public void TestPushWithPeek()
    {
      MyStack<string> stack = new MyStack<string>();
      stack.Push("1");
      stack.Push("2");
      stack.Push("3");
      stack.Push("4");
      Assert.AreEqual("4", stack.Peek());
    }

    [TestMethod]
    public void TestPopWithOneElement()
    {
      MyStack<string> stack = new MyStack<string>();
      stack.Push("1");
      Assert.AreEqual("1", stack.Pop());
      Assert.IsTrue(stack.count == 0);
    }

    [TestMethod]
    public void TestPopWithTwoElements()
    {
      MyStack<string> stack = new MyStack<string>();
      stack.Push("1");
      stack.Push("2");
      Assert.AreEqual("2", stack.Pop());
      Assert.AreEqual("1", stack.Peek());
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPopOnEmptyStack()
    {
      MyStack<string> stack = new MyStack<string>();
      stack.Pop();
     
    }

    [TestMethod]
    public void TestClearWithCount()
    {
      MyStack<string> stack = new MyStack<string>();
      stack.Push("1");
      stack.Push("2");
      stack.Push("3");
      stack.Push("4");
      stack.Push("5");
      stack.Clear();
      Assert.IsTrue(stack.count == 0);
    }

    [TestMethod]
    public void TestIsEmptyOnEmptyStack()
    {
      MyStack<string> stack = new MyStack<string>();  
      Assert.IsTrue(stack.IsEmpty());
    }
  }
}
