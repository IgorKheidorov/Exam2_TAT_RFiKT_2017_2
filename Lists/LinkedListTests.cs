using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedLists;

namespace Tests
{
  [TestClass]
  public class LinkedListTests
  {
    [TestMethod]
    public void LinkedListTestGetNext()
    {
      MyLinkedList list = new MyLinkedList(5);
      Assert.AreEqual(5, list.GetNext().Value);
    }
    [TestMethod]
    public void LinkedListTestAdd()
    {
      MyLinkedList list = new MyLinkedList();
      list.Add(10);
      Assert.AreEqual(10, list.GetHead().Value);
    }
    [TestMethod]
    public void LinkedListTestRemove()
    {
      MyLinkedList list = new MyLinkedList();
      list.Add(10);
      list.Add(15);
      list.Add(20);
      Assert.AreEqual(true, list.Remove(15));
    }
    [TestMethod]
    public void LinkedListTestAddFirst()
    {
      MyLinkedList list = new MyLinkedList();
      list.Add(10);
      list.Add(15);
      list.Add(20);
      list.AddFirst(5);
      Assert.AreEqual(5, list.GetHead().Value);
    }
    [TestMethod]
    public void LinkedListTestClear()
    {
      MyLinkedList list = new MyLinkedList();
      list.Add(10);
      list.Add(15);
      list.Clear();
      Assert.AreEqual(null, list.GetHead());
      Assert.AreEqual(null, list.GetTail());
      Assert.AreEqual(0, list.Count);
    }
    [TestMethod]
    public void LinkedListTestContains()
    {
      MyLinkedList list = new MyLinkedList();
      list.Add(10);
      list.Add(15);
      list.Add(20);
      Assert.AreEqual(true, list.Contains(15));
    }
    [TestMethod]
    public void LinkedListTestGetHead()
    {
      MyLinkedList list = new MyLinkedList();
      list.Add(10);
      list.Add(15);
      list.Add(20);
      Assert.AreEqual(10, list.GetHead().Value);
    }
    [TestMethod]
    public void LinkedListTestGetTail()
    {
      MyLinkedList list = new MyLinkedList();
      list.Add(10);
      list.Add(15);
      list.Add(20);
      Assert.AreEqual(20, list.GetTail().Value);
    }
  }
}
