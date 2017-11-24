using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlToDom;

namespace UnitTestOnXmlToDom
{
  [TestClass]
  public class Tests
  {
    [TestMethod]
    public void TestOnReadXml()
    {
      String StringInXml = "<?xml version=" + "1.0"+ "encoding=" + "utf - 8" + "?><cars>  <car>  </car>  <car>  </car></cars>";
      WorkWithXml workWithXml = new WorkWithXml();
      workWithXml.ReadXmlFile();
      Assert.AreEqual(true, StringInXml.Equals(workWithXml.getAllXml()));
    }
  }
}
