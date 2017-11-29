using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedLists;

namespace ListsTest
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void NegativeTestChecksContains()
        {
            Assert.IsFalse(new LinkedList().Contains(3));
        }
        [TestMethod]
        public void NegativeTestChecksRemove()
        {
            Assert.IsFalse(new LinkedList().Remove(3));
        }
        [TestMethod]
        public void PositiveTestChecksRemoveFirstElement()
        {
            LinkedList list = new LinkedList();
            list.Add(3);
            Assert.IsTrue(list.Remove(3));
        }
        [TestMethod]
        public void PositiveTestChecksRemoveElementInTheMiddleOfTheList()
        {
            LinkedList list = new LinkedList();
            list.Add(3);
            list.Add(5);
            list.Add(1);
            Assert.IsTrue(list.Remove(3));
        }
        [TestMethod]
        public void PositiveTestChecksAdd()
        {
            LinkedList list = new LinkedList();
            list.Add(3);
            Assert.AreEqual(1, list.Count);
        }
        [TestMethod]
        public void PositiveTestChecksAddLotsOfValue()
        {
            LinkedList list = new LinkedList();
            list.Add(3);
            list.Add(5);
            list.Add(1);
            Assert.AreEqual(3, list.Count);
        }
        [TestMethod]
        public void PositiveTestChecksContains()
        {
            LinkedList list = new LinkedList();
            list.Add(3);
            list.Add(5);
            list.Add(1);
            Assert.IsTrue(list.Contains(5));
        }
        [TestMethod]
        public void NegativeTestChecksContainsNonExistElement()
        {
            LinkedList list = new LinkedList();
            list.Add(3);
            list.Add(5);
            list.Add(1);
            Assert.IsFalse(list.Contains(0));
        }
        [TestMethod]
        public void NegativeTestChecksInsert()
        {
            LinkedList list = new LinkedList();
            list.Add(3);
            list.Add(5);
            list.Add(1);
            list.Insert(1, 2);
            Assert.AreEqual(4, list.Count);
        }
        [TestMethod]
        public void NegativeTestChecksContainsNonExistElementInDoubleLinkedList()
        {
            DoubleLinkedList list = new DoubleLinkedList();
            list.Add(3);
            list.Add(5);
            list.Add(1);
            Assert.AreEqual(3,list.Count);
        }
    }
}
