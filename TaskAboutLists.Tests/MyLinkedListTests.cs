using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskAboutLists.Tests
{
    [TestClass]
    public class MyLinkedListTests
    {
        [TestMethod]
        public void TestContains()
        {
            MyLinkedList<string> list = new MyLinkedList<string>();
            list.Add("firstValue");
            Assert.IsTrue( list.Contains("firstValue"));
            Assert.IsFalse(list.Contains("something"));
        }

        [TestMethod]
        public void TestAddOnCount()
        {
            MyLinkedList<string> list = new MyLinkedList<string>();
            list.Add("firstValue");
            Assert.AreEqual(1, list.count);                    
        }

        [TestMethod]
        public void TestGetElelement()
        {
            MyLinkedList<string> list = new MyLinkedList<string>();
            list.Add("firstValue");
            Assert.AreEqual("firstValue", list.GetElement("firstValue").value);
        }

        [TestMethod]
        public void TestAdd()
        {
            MyLinkedList<string> list = new MyLinkedList<string>();
            list.Add("firstValue");
            Assert.AreEqual("firstValue", list.GetFirst());
        }

        [TestMethod]
        public void TestRemove()
        {
            MyLinkedList<string> list = new MyLinkedList<string>();
            list.Add("firstValue");
            list.Add("secondValue");
            list.Remove("firstValue");
            Assert.IsFalse(list.Contains("secondValue"));
        }

        [TestMethod]
        public void TestRemoveFirst()
        {
            MyLinkedList<string> list = new MyLinkedList<string>();
            list.Add("firstValue");
            list.Add("secondValue");
            list.RemoveFirst();
            Assert.IsFalse(list.Contains("firstValue"));
        }

        [TestMethod]
        public void TestClear()
        {
            MyLinkedList<string> list = new MyLinkedList<string>();
            list.Add("firstValue");
            list.Add("secondValue");
            list.Clear();
            Assert.IsFalse(list.Contains("firstValue"));
            Assert.IsFalse(list.Contains("secondValue"));
        }



    }
}
