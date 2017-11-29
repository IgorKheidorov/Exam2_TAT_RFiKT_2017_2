using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnidirectionalListBidirectionalList;

namespace UnitTestHandMadeLists
{
  [TestClass]
  public class PositiveTests
  {
    [TestMethod]
    public void CheckIsEmptyListUnidirectionalList()
    {
      UnidirectionalList<string> unidirectionalList = new UnidirectionalList<string>();
      Assert.IsTrue(unidirectionalList.IsEmpty());
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
      Assert.IsTrue(unidirectionalList.GetData(6).Equals("Final"));
    }

    [TestMethod]
    public void CheckOnExistElementInListUnidirectionalList()
    {
      UnidirectionalList<string> unidirectionalList = new UnidirectionalList<string>();
      unidirectionalList.AddElement("First");
      unidirectionalList.AddElement("Second");
      unidirectionalList.AddElement("Third");
      Assert.IsTrue(unidirectionalList.Contains("Third"));
    }

    [TestMethod]
    public void CheckOnExistBidirectionalList()
    {
      BidirectorialList<string> bidirectorialList = new BidirectorialList<string>();
      bidirectorialList.AddElement("First");
      bidirectorialList.AddElement("Second");
      bidirectorialList.AddElement("Third");
      Assert.IsTrue(bidirectorialList.Contains("Third"));
    }

    

    [TestMethod]
    public void CheckOnAddElementBidirectionalList()
    {
      BidirectorialList<string> bidirectorialList = new BidirectorialList<string>();
      bidirectorialList.AddElement("First");
      bidirectorialList.AddElement("Third");
      bidirectorialList.AddElement("First");
      bidirectorialList.AddElement("Second");
      bidirectorialList.AddElement("First");
      bidirectorialList.AddElement("Third");
      bidirectorialList.AddElement("Final");
      Assert.IsTrue(bidirectorialList.GetData(4).Equals("First"));
    }

    [TestMethod]
    public void CheckIsEmptyListBidirectionalList()
    {
      BidirectorialList<string> bidirectorialList = new BidirectorialList<string>();
      Assert.IsTrue(bidirectorialList.IsEmpty());
    }

    [TestMethod]
    public void CheckIsRemoveListBidirectionalList()
    {
      BidirectorialList<string> bidirectorialList = new BidirectorialList<string>();
      bidirectorialList.AddElement("Third");
      bidirectorialList.Remove("Third");
      Assert.IsTrue(bidirectorialList.IsEmpty());
    }

    [TestMethod]
    public void CheckOnAddOnFirsPosition()
    {
      BidirectorialList<string> bidirectorialList = new BidirectorialList<string>();
      bidirectorialList.AddElement("Second");
      bidirectorialList.AddOnFirstElement("First");
      Assert.IsTrue(bidirectorialList.GetData(0).Equals("First"));
      Assert.IsTrue(bidirectorialList.GetData(1).Equals("Second"));
    }
  }
}
