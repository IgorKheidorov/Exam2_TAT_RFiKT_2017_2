using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_1.Tests
{
    [TestClass]
    public class StringAnalyzerTests
    {
        StringAnalyzer analyzer = new StringAnalyzer();
        [TestMethod]
        public void TestConvertStringToIntOnIntegerOnInteger()
        {
            Assert.IsTrue(analyzer.StringIsInteger("11"));
        }

        [TestMethod]
        public void TestConvertStringToIntOnIntegerOnEmpryStirng()
        {
            Assert.IsFalse(analyzer.StringIsInteger(""));
        }

        [TestMethod]
        public void TestConvertStringToIntOnIntegerOnPositiveBorderValue()
        {
            Assert.IsFalse(analyzer.StringIsInteger("2,147,483,647"));
        }

        [TestMethod]
        public void TestConvertStringToIntOnIntegerOnNegativeBorderValue()
        {
            Assert.IsFalse(analyzer.StringIsInteger("-2,147,483,648"));
        }

        [TestMethod]
        public void TestConvertStringToIntOnIntegerOnDotAndComma()
        {
            Assert.IsFalse(analyzer.StringIsInteger("-2,2334.0301"));
        }

        [TestMethod]
        public void TestConvertStringToIntOnIntegerOnLetters()
        {
            Assert.IsFalse(analyzer.StringIsInteger("grrehre"));
        }
    }
}
