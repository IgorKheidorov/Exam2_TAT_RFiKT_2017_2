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
  }
}