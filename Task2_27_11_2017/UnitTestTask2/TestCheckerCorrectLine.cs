using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2_27_11_2017;

namespace UnitTestTask2
{
    [TestClass]
    public class TestCheckerCorrectLine
    {
        [TestMethod]
        public void TestCheckByParethnesisValidLine()
        {
            CheckerCorrectLine checker = new CheckerCorrectLine("{()[]}(){}");

            Assert.AreEqual(true, checker.CheckByBrakets());
        }

        [TestMethod]
        public void TestCheckByBraketsWithoutOpenBrekets()
        {
            CheckerCorrectLine checker = new CheckerCorrectLine("})]");

            Assert.AreEqual(false, checker.CheckByBrakets());
        }

        [TestMethod]
        public void TestCheckByBraketsWithoutClosingBrekets()
        {
            CheckerCorrectLine checker = new CheckerCorrectLine("{}[");

            Assert.AreEqual(false, checker.CheckByBrakets());
        }

        [TestMethod]
        public void TestCheckByBraketsUncorrectBreketsOrder()
        {
            CheckerCorrectLine checker = new CheckerCorrectLine("{[}]");

            Assert.AreEqual(false, checker.CheckByBrakets());
        }

        [TestMethod]
        public void TestCheckByBraketsWithoutBrekets()
        {
            CheckerCorrectLine checker = new CheckerCorrectLine("54 + 5");

            Assert.AreEqual(true, checker.CheckByBrakets());
        }

        [TestMethod]
        public void TestCheckByBraketsEmptyLine()
        {
            CheckerCorrectLine checker = new CheckerCorrectLine("");

            Assert.AreEqual(true, checker.CheckByBrakets());
        }
    }
}
