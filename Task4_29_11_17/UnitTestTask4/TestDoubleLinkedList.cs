using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4_29_11_17;

namespace UnitTestTask4
{
    [TestClass]
    public class TestDoubleLinkedList
    {
        [TestMethod]
        public void TestCount()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(1);
            list.Add(2);

            Assert.AreEqual(2, list.Count());
        }

        [TestMethod]
        public void TestCountInEmptyList()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();

            Assert.AreEqual(0, list.Count());
        }

        [TestMethod]
        public void TestAdd()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(1);

            Assert.AreEqual(1, list.GetTail().Value);
        }

        [TestMethod]
        public void TestRemove()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.Remove(2);

            Assert.AreEqual(3, list.GetHead().Next.Value);
        }

        [TestMethod]
        public void TestRemoveIfElementNotAtList()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            
            Assert.AreEqual(false, list.Remove(4));
        }

        [TestMethod]
        public void TestGetPositionOfElement()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Assert.AreEqual(2, list.GetPositionOfElement(3));
        }

        [TestMethod]
        public void TestGetPositionOfElementIfElementNotAtList()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Assert.AreEqual(-1, list.GetPositionOfElement(4));
        }
    }
}