using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackRealisation;

namespace StackRealisationTest
{
    [TestClass]
    public class PositiveStackRealisationTest
    {
        [TestMethod]
        public void TestStack_CountIsEqualZero()
        {
            Assert.AreEqual(0, new MyStack<int>().Count);
        }
        [TestMethod]
        public void TestStackIsEmpty()
        {
            Assert.IsTrue(new MyStack<int>().IsEmpty);
        }
        [TestMethod]
        public void TestChecksStackPush_InsertsOneValue_StackCountEqualsToOne()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(3);
            Assert.AreEqual(1,stack.Count);
        }
        [TestMethod]
        public void TestChecksStackPush_InsertsFiveValues()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            Assert.AreEqual(5, stack.Count);
        }
        [TestMethod]
        public void TestChecksStackPop_RemovesOneValue_ReturnsRemovedValue()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(3);
            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(0, stack.Count);
        }
        [TestMethod]
        public void TestChecksStackPop_RemovesOnlyOneLastValue()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(3);
            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(0, stack.Count);
        }
        [TestMethod]
        public void TestChecksStackRuleLIFO()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            Assert.AreEqual(7, stack.Pop());
            Assert.AreEqual(4, stack.Count);
        }
        [TestMethod]
        public void TestChecksStackPeek_ShowsHeadVaue_ReturnsHeadValueWithoutRemoving()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(3);
            Assert.AreEqual(3, stack.Peek());
            Assert.AreEqual(1, stack.Count);
        }
        [TestMethod]
        public void TestChecksStackPeek_ShowsHeadVaueFromTenValues()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(19);
            Assert.AreEqual(19, stack.Peek());
        }
        [TestMethod]
        public void TestChecksStackClear_DeleteAllValues_StackCountEqualsToZero()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Clear();
            Assert.AreEqual(0, stack.Count);
        }
        [TestMethod]
        public void TestChecksStackClearForEmptyStack()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Clear();
            Assert.AreEqual(0, stack.Count);
        }
    }
}
