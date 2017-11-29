using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnidirectionalListBidirectionalList;

namespace UnitTestHandMadeLists
{
  [TestClass]
  public class NegativeTests
  {
    public void CheckIsEmptyListUnidirectionalList()
    {
      UnidirectionalList<string> unidirectionalList = new UnidirectionalList<string>();
      unidirectionalList.AddElement("First");
      Assert.IsFalse(unidirectionalList.IsEmpty());
    }

    [TestMethod]
    public void CheckOnUnExistElementInListUnidirectionalList()
    {
      UnidirectionalList<string> unidirectionalList = new UnidirectionalList<string>();
      unidirectionalList.AddElement("First");
      unidirectionalList.AddElement("Second");
      unidirectionalList.AddElement("Third");
      Assert.IsFalse(unidirectionalList.Contains("third"));
    }

    [TestMethod]
    public void CheckOnAddElementUnidirectionalList()
    {
      UnidirectionalList<string> unidirectionalList = new UnidirectionalList<string>();
      unidirectionalList.AddElement("First");
      unidirectionalList.AddElement("Third");
      unidirectionalList.AddElement("First");
      unidirectionalList.AddElement("Second");
      unidirectionalList.AddElement("First");
      unidirectionalList.AddElement("Third");
      unidirectionalList.AddElement("Final");
      Assert.IsFalse(unidirectionalList.GetData(6).Equals("First"));
    }

    [TestMethod]
    public void CheckOnRemoveUnidirectionalList()
    {
      UnidirectionalList<string> unidirectionalList = new UnidirectionalList<string>();
      unidirectionalList.AddElement("First");
      unidirectionalList.AddElement("Second");
      unidirectionalList.AddElement("Third");
      unidirectionalList.Remove("Third");
      Assert.IsFalse(unidirectionalList.Contains("Third"));
    }

    [TestMethod]
    public void CheckOnRemoveBidirectionalList()
    {
      BidirectorialList<string> bidirectorialList = new BidirectorialList<string>();
      bidirectorialList.AddElement("First");
      bidirectorialList.AddElement("Second");
      bidirectorialList.AddElement("Third");
      bidirectorialList.Remove("Third");
      Assert.IsFalse(bidirectorialList.Contains("Third"));
    }

    [TestMethod]
    public void CheckIsEmptyListBidirectionalList()
    {
      BidirectorialList<string> bidirectorialList = new BidirectorialList<string>();
      bidirectorialList.AddElement("First");
      Assert.IsFalse(bidirectorialList.IsEmpty());
    }

    [TestMethod]
    public void CheckIsRemoveListBidirectionalList()
    {
      BidirectorialList<string> bidirectorialList = new BidirectorialList<string>();
      bidirectorialList.AddElement("Third");
      bidirectorialList.Remove("Third");
      Assert.IsFalse(bidirectorialList.Contains("Third"));
    }
  }
}
