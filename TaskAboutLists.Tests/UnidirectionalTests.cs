using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskAboutLists.Tests
{
    [TestClass]
    public class UnidirectionalTests
    {

        [TestMethod]
        public void TestAddOnCount()
        {
            UnidirectionalList<string> list = new UnidirectionalList<string>();
            list.Add("firstValue");
            Assert.AreEqual(1, list.count);
        }
    }
    }

