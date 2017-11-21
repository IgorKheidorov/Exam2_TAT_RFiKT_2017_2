using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exam;

namespace TestTask1
{
    [TestClass]
    public class IntegerParserTest
    {
        [TestMethod]
        public void TestPositiveNumber()
        {
            Assert.AreEqual(123, new IntegerParser("123").Parse());
        }
        [TestMethod]
        public void TestNegativeNumber()
        {
            Assert.AreEqual(-12, new IntegerParser("-12").Parse());
        }
        [TestMethod]
        public void TestComma()
        {
            Assert.AreEqual(12, new IntegerParser("12,").Parse());
        }
        [TestMethod]
        public void TestZero()
        {
            Assert.AreEqual(0, new IntegerParser("0").Parse());
        }

    }
}
