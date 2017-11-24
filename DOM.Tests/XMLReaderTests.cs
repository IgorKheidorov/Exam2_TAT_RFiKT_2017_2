using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DOM.Tests
{
  [TestClass]
  public class XMLReaderTests
  {
    string xml = "<cars>\n<car>\nvolvo\n</car>\n</cars>";

    [TestMethod]
    public void GetRootTag_xml_rootExpected()
    {
      string filePath = "C:\\Users\\user\\Documents\\Visual Studio 2017\\Projects\\XMLParser\\file.xml";
      Assert.AreEqual("<cars>", new XMLReader(filePath).GetRootTag(xml));
    }
  }
}