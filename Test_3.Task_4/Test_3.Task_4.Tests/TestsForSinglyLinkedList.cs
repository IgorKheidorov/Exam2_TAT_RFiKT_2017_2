using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_3.Task_4.Tests
{
  [TestClass]
  public class TestsForSinglyLinkedList
  {
    [TestMethod]
    public void PositiveTestContains()
    {
      SinglyLinkedList list = new SinglyLinkedList();
      list.AddBack(1);
      list.AddBack(2);
      list.AddBack(3);

      Assert.AreEqual(true, list.Contains(2));
    }

    [TestMethod]
    public void NegativeTestContains()
    {
      SinglyLinkedList list = new SinglyLinkedList();
      list.AddBack(1);
      list.AddBack(2);
      list.AddBack(3);

      Assert.AreEqual(false, list.Contains(5));
    }

    [TestMethod]
    public void PositiveTestCount()
    {
      SinglyLinkedList list = new SinglyLinkedList();
      list.AddBack(1);
      list.AddBack(2);
      list.AddBack(3);

      Assert.AreEqual(3, list.Count);
    }

    [TestMethod]
    public void NegativeTestCount()
    {
      SinglyLinkedList list = new SinglyLinkedList();
      list.AddBack(1);
      list.AddBack(2);
      list.AddBack(3);

      Assert.AreNotEqual(5, list.Count);
    }

    [TestMethod]
    public void TestGetNext()
    {
      SinglyLinkedList list = new SinglyLinkedList();
      Node node = new Node(2);
      node.Next = new Node(3);
      list.AddBack(1);
      list.AddBack(2);
      list.AddBack(3);
      list.AssignFirstToCurrent();
      list.GetNext();

      Assert.AreEqual(node, list.GetNext().Value);
      Assert.AreEqual(node, list.GetNext().Next);
    }
  }
}
