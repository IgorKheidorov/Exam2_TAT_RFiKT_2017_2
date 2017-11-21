using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace UnitTestTask1
{
    [TestClass]
    public class TestConverterToIntFromString
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestConvertLineToIntUncorrectLine()
        {
            ConverterToIntFromString convert = new ConverterToIntFromString();
            convert.ConvertLineToInt("abs");
        }
    }
}
