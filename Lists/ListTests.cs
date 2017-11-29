using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedLists;

namespace Tests
{
  [TestClass]
  public class ListTests
  {
    [TestMethod]
    public void ListTestGetNext()
    {
      MyList list = new MyList(5);
      Assert.AreEqual(5, list.GetNext().Value);
    }
    [TestMethod]
    public void ListTestAdd()
    {
      MyList list = new MyList();
       list.Add(10);
      Assert.AreEqual(10,list.GetTail().Value);
    }
    [TestMethod]
    public void ListTestRemove()
    {
      MyList list = new MyList();
      list.Add(10);
      list.Add(15);
      list.Add(20);
      Assert.AreEqual(true, list.Remove(15));
    }
    [TestMethod]
    public void ListTestAddFirst()
    {
      MyList list = new MyList();
      list.Add(10);
      list.Add(15);
      list.Add(20);
      list.AddFirst(5);
      Assert.AreEqual(5, list.GetHead().Value);
    }
    [TestMethod]
    public void ListTestClear()
    {
      MyList list = new MyList();
      list.Add(10);
      list.Add(15);
      list.Clear();
      Assert.AreEqual(null, list.GetHead());
      Assert.AreEqual(null, list.GetTail());
      Assert.AreEqual(0, list.Count);
    }
    [TestMethod]
    public void ListTestContains()
    {
      MyList list = new MyList();
      list.Add(10);
      list.Add(15);
      list.Add(20);
      Assert.AreEqual(true, list.Contains(15));
    }
    [TestMethod]
    public void ListTestGetHead()
    {
      MyList list = new MyList();
      list.Add(10);
      list.Add(15);
      list.Add(20);
      Assert.AreEqual(10, list.GetHead().Value);
    }
    [TestMethod]
    public void ListTestGetTail()
    {
      MyList list = new MyList();
      list.Add(10);
      list.Add(15);
      list.Add(20);
      Assert.AreEqual(20, list.GetTail().Value);
    }
  }
}
