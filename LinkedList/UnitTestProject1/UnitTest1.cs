using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoTypesOfList;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethodAddToDLL()
    {
      DoublyLinkedList linkedList = new DoublyLinkedList();
      linkedList.AddValueToDoublyLinkedList(1);
      linkedList.AddValueToDoublyLinkedList(2);
      Assert.AreEqual(2, linkedList.Tail.Value);
    }

    [TestMethod]
    public void TestMethodRemoveFromDLL()
    {
      DoublyLinkedList list = new DoublyLinkedList();
      list.AddValueToDoublyLinkedList(1);
      list.AddValueToDoublyLinkedList(2);
      list.AddValueToDoublyLinkedList(3);
      list.AddValueToDoublyLinkedList(4);
      list.Remove(4);
      Assert.AreEqual(3, list.Tail.Value);
    }

    [TestMethod]
    public void TestMethodAddFirstToDLL()
    {
      DoublyLinkedList list = new DoublyLinkedList();
      list.AddValueToDoublyLinkedList(1);
      list.AddValueToDoublyLinkedList(2);
      list.AddFirst(0);
      Assert.AreEqual(0, list.Head.Value);
    }

    [TestMethod]
    public void TestMethodAddToLL()
    {
      LinkedList linkedList = new LinkedList();
      linkedList.AddValueToLinkedList(4);
      linkedList.AddValueToLinkedList(5);
      Assert.AreEqual(4, linkedList.Head.Value);
    }

    [TestMethod]
    public void TestMethodAddFirstToLL()
    {
      LinkedList linkedList = new LinkedList();
      linkedList.AddValueToLinkedList(4);
      linkedList.AddValueToLinkedList(5);
      linkedList.AppendFirst(1);
      Assert.AreEqual(1, linkedList.Head.Value);
    }
  }
}
