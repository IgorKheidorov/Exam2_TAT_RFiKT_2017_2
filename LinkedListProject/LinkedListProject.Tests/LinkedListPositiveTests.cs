using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListProject.Tests
{
  [TestClass]
  public class LinkedListPositiveTests
  {
    [TestMethod]
    public void Add_intElement_listWithThisElement()
    {
      LinkedList<int> linkedList = new LinkedList<int>();
      linkedList.Add(2);
      Assert.AreEqual(2, linkedList.Tail.Value);
    }

    [TestMethod]
    public void Add_intElement_CountEquals1()
    {
      LinkedList<int> linkedList = new LinkedList<int>();
      linkedList.Add(2);
      Assert.AreEqual(1, linkedList.Count);
    }

    [TestMethod]
    public void Remove_oneIntElement_CountDecreaseBy1()
    {
      LinkedList<int> linkedList = new LinkedList<int>(2);
      linkedList.Remove(2);
      Assert.AreEqual(0, linkedList.Count);
    }

    [TestMethod]
    public void Contains_5inListWith5_truevalue()
    {
      Assert.AreEqual(true, new LinkedList<int>(5).Contains(5));
    }

    [TestMethod]
    public void Addfirst_5value_listWith5inHead()
    {
      LinkedList<int> LinkedList = new LinkedList<int>();
      LinkedList.Add(2);
      LinkedList.Add(4);
      LinkedList.AddFirst(9);
      Assert.AreEqual(9, LinkedList.Head.Value);
    }
  }
}