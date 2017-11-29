using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListsWithoutCollectionGeneric;


namespace UnitTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestAddValueToEndInLinkedList()
    {
      LinkedList list = new LinkedList();
      list.AddToEnd(5);
      Assert.AreEqual(5,list.Tail.Value);
    }

    [TestMethod]
    public void TestAddValueToStartInLinkedList()
    {
      LinkedList list = new LinkedList();
      list.AddToEnd(5);
      Assert.AreEqual(5, list.Tail.Value);
    }

    [TestMethod]
    public void TestAddValueToEndInDoublyLinkedList()
    {
      DoublyLinkedList list = new DoublyLinkedList();
      list.AddToEnd(5);
      Assert.AreEqual(5, list.Tail.Value);
    }

    [TestMethod]
    public void TestAddValueToStartInDoublyLinkedList()
    {
      DoublyLinkedList list = new DoublyLinkedList();
      list.AddToStart(5);
      Assert.AreEqual(5, list.Head.Value);
    }

    [TestMethod]
    public void TestRemoveValueInDoublyLinkedList()
    {
      DoublyLinkedList list = new DoublyLinkedList();
      list.AddToStart(5);
      list.AddToEnd(4);
      list.AddToEnd(3);
      list.Remove(3);
      Assert.AreEqual(4, list.Tail.Value);
    }

    [TestMethod]
    public void TestRemoveValueInNullDoublyLinkedList()
    {
      LinkedList list = new LinkedList();
      list.AddToStart(1);
      list.AddToEnd(2);
      list.AddToEnd(4);
      list.RemoveFromLinkedList(4);
      Assert.AreEqual(2, list.Tail.Value);
    }
  }
}
