using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LikeDOMObject;

namespace DOMParserTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Element expectedElement = new Element();
      expectedElement.Tag = "name";
      expectedElement.Text = "somename";
      Element element = new DOMParser("<name>somename</name>").MakeElement();
      Assert.AreEqual(expectedElement, element);
    }
  }
}
