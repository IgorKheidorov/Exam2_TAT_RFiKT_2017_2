using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackProject.Tests
{
  [TestClass]
  public class StackPositiveTests
  {
    [TestMethod]
    public void Push_threeValues_stackCountEquals3()
    {
      Stack<int> stack = new Stack<int>();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      Assert.AreEqual(3, stack.Count);
    }

    [TestMethod]
    public void Peek_severalValues_lastAddedValue()
    {
      Stack<int> stack = new Stack<int>();
      stack.Push(2);
      stack.Push(4);
      stack.Push(6);
      stack.Push(8);
      Assert.AreEqual(8, stack.Peek());
      Assert.AreEqual(4, stack.Count);
    }

    [TestMethod]
    public void Pop_severalValues_lastAddedValue()
    {
      Stack<int> stack = new Stack<int>();
      stack.Push(10);
      stack.Push(15);
      Assert.AreEqual(15, stack.Pop());
      Assert.AreEqual(1, stack.Count);
    }

    [TestMethod]
    public void IsEmpty_addValueAndPopIt_true()
    {
      Stack<string> stack = new Stack<string>();
      stack.Push("Stack");
      stack.Pop();
      Assert.AreEqual(true, stack.IsEmpty());
      Assert.AreEqual(0, stack.Count);
    }

    [TestMethod]
    public void IsEmpty_emptyStack_true()
    {
      Stack<string> stack = new Stack<string>();
      Assert.AreEqual(true, stack.IsEmpty());
    }

    [TestMethod]
    public void PushAndPop_addSeveralValuesAndPopSeveralValues_lastAddedValue()
    {
      Stack<int> stack = new Stack<int>();
      stack.Push(2);
      stack.Push(4);
      stack.Push(6);
      stack.Push(8);
      stack.Pop();
      stack.Pop();
      Assert.AreEqual(4, stack.Pop());
      Assert.AreEqual(1, stack.Count);
    }
  }
}