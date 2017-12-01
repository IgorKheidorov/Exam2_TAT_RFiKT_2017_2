using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackRealisation;

namespace StackRealisationTest
{
    [TestClass]
    public class NegativeStackRealisationTest
    {
        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void TestStackPeekFromEmptyStack()
        {
            Assert.AreEqual(0, new MyStack<int>().Peek());
        }

        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void TestStackPopFromEmptyStack()
        {
            Assert.AreEqual(0, new MyStack<int>().Pop());
        }

        [TestMethod]
        public void TestChecksStackRule_LIFO_TakesLastElement()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(3);
            stack.Push(4);
            Assert.IsFalse(3 == stack.Pop());
        }
        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void TestStack_PusOneElements_PopTwoElements()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(3);
            stack.Pop();
            Assert.AreEqual(0, stack.Pop());
        }
    }
}
