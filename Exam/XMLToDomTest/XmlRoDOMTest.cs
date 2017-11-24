using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XMLToDomTask;

namespace XMLToDomTest
{
    [TestClass]
    public class XmlRoDOMTest
    {
        [TestMethod]
        public void TestFirstNode()
        {
            Assert.AreEqual(false, new XMLFormat().TryParse());
        }
    }
}
