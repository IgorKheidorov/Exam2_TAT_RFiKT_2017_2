using MyStack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
  [TestClass]
  public class Positive
  {
    [TestMethod]
    public void TestPush()
    {
      StackOnList<int> stack = new StackOnList<int>();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      Assert.AreEqual(3, stack.Count);
    }

    [TestMethod]
    public void TestPop()
    {
      StackOnList<int> stack = new StackOnList<int>();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      Assert.AreEqual(3, stack.Pop());
      Assert.AreEqual(2, stack.Count);
    }

    [TestMethod]
    public void TestPeek()
    {
      StackOnList<int> stack = new StackOnList<int>();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      Assert.AreEqual(3, stack.Peek());
      Assert.AreEqual(3, stack.Count);
    }

    [TestMethod]
    public void TestClear()
    {
      StackOnList<int> stack = new StackOnList<int>();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Clear();
      Assert.AreEqual(0, stack.Count);
    }

    [TestMethod]
    public void TestAllFunctions()
    {
      StackOnList<int> stack = new StackOnList<int>();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Push(4);

      stack.Pop();
      stack.Peek();
      Assert.AreEqual(3, stack.Count);
    }
  }
}
