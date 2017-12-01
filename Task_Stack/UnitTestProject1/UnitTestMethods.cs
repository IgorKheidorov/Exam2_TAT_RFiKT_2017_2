using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskStack;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTestMethods
  {
    [TestMethod]
    public void TestPeek()
    {
      NodeStack<int> nodeStack = new NodeStack<int>();
      nodeStack.Push(1);
      nodeStack.Push(2);
      nodeStack.Push(3);
      Assert.AreEqual(3, nodeStack.Peek());
      Assert.AreEqual(3, nodeStack.Peek());
    }

    [TestMethod]
    public void TestPop()
    {
      NodeStack<int> nodeStack = new NodeStack<int>();
      nodeStack.Push(1);
      nodeStack.Push(2);
      nodeStack.Push(4);
      Assert.AreEqual(4, nodeStack.Pop());
      Assert.AreEqual(2, nodeStack.Count);
    }  

    [TestMethod]
    public void TestClear()
    {
      NodeStack<int> nodeStack = new NodeStack<int>();
      nodeStack.Push(1);
      nodeStack.Push(2);
      nodeStack.Push(4);
      nodeStack.Clear();
      Assert.AreEqual(0, nodeStack.Count);
    }

    [TestMethod]
    public void TestPush()
    {
      NodeStack<int> nodeStack = new NodeStack<int>();
      nodeStack.Push(1);
      nodeStack.Push(2);
      nodeStack.Push(4);      
      Assert.AreEqual(3, nodeStack.Count);
    }
  }
}