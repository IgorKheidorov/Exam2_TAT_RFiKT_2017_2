using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackImplementation;
namespace Tests
{
  [TestClass]
  public class PositiveTests
  {
    [TestMethod]
    public void TestPush()
    {
      MyStack<int> stack = new MyStack<int>();
      stack.Push(5);
      Assert.AreEqual(1,stack.Count);
    }
    [TestMethod]
    public void TestPeek()
    {
      MyStack<int> stack = new MyStack<int>();
      stack.Push(10);
      stack.Push(15);
      Assert.AreEqual(15, stack.Peek());
      Assert.AreEqual(2, stack.Count);
    }
    [TestMethod]
    public void TestPop()
    {
      MyStack<int> stack = new MyStack<int>();
      stack.Push(20);
      stack.Push(25);
      Assert.AreEqual(25, stack.Pop());
      Assert.AreEqual(1, stack.Count);
    }
    [TestMethod]
    public void TestClear()
    {
      MyStack<int> stack = new MyStack<int>();
      stack.Push(5);
      stack.Push(10);
      stack.Push(15);
      stack.Clear();
      Assert.AreEqual(0, stack.Count);
    }
  }
}
