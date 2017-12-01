using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackProject.Tests
{
  [TestClass]
  public class StackNegativeTests
  {
    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Pop_emptyStack_exceptionExpected()
    {
      new Stack<int>().Pop();
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Peek_emptyStack_exceptionExpected()
    {
      new Stack<int>().Peek();
    }

    [TestMethod]
    public void IsEmpty_stackWithValue_false()
    {
      Stack<string> stack = new Stack<string>();
      stack.Push("Stack");
      Assert.AreEqual(false, stack.IsEmpty());
    }
  }
}