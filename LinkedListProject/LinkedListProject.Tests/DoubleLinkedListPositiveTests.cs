using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListProject.Tests
{
  [TestClass]
  public class DoubleLinkedListPositiveTests
  {
    [TestMethod]
    public void Add_intElement_listWithThisElement()
    {
      DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
      doubleLinkedList.Add(2);
      Assert.AreEqual(2, doubleLinkedList.Tail.Value);
    }

    [TestMethod]
    public void Add_intElement_CountEquals1()
    {
      DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
      doubleLinkedList.Add(2);
      Assert.AreEqual(1, doubleLinkedList.Count);
    }

    [TestMethod]
    public void Remove_oneIntElement_CountDecreaseBy1()
    {
      DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>(2);
      doubleLinkedList.Remove(2);
      Assert.AreEqual(0, doubleLinkedList.Count);
    }

    [TestMethod]
    public void Contains_5inListWith5_truevalue()
    {
      Assert.AreEqual(true, new DoubleLinkedList<int>(5).Contains(5));
    }
  }
}