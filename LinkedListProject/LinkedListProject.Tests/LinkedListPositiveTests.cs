using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListProject.Tests
{
  [TestClass]
  public class LinkedListPositiveTests
  {
    [TestMethod]
    public void Add_intElement_listWithThisElement()
    {
      LinkedList<int> linkedList = new LinkedList<int>(1);
      linkedList.Add(2);
    }
  }
}
