using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TuesdayTask;

namespace ComplexNumberTest
{
    [TestClass]
    public class ComplexNumberTest
    {
        [TestMethod]
        public void PositiveTestForRightOutputsOfComplexNumber()
        {
            Assert.AreEqual("2 + 3i", new ComplexNumber(2,3).ToString());
        }
        [TestMethod]
        public void PositiveTestForEqualComplexNumber()
        {
            Assert.AreEqual(0, new ComplexNumber(2, 3).CompareTo(new ComplexNumber(2, 3)));
        }
        [TestMethod]
        public void PositiveTestForThisComplexNumberLessThanComplexNumberInMethod()
        {
            Assert.AreEqual(-1, new ComplexNumber(1, 3).CompareTo(new ComplexNumber(2, 3)));
        }
        [TestMethod]
        public void PositiveTestForThisComplexNumberGreaterThanComplexNumberInMethod()
        {
            Assert.AreEqual(1, new ComplexNumber(2, 3).CompareTo(new ComplexNumber(1, 3)));
        }
        [TestMethod]
        public void PositiveTestForAddition()
        {
            Assert.AreEqual(new ComplexNumber(3, 6).ToString(), (new ComplexNumber(2, 3)
                + (new ComplexNumber(1, 3))).ToString());
        }
        [TestMethod]
        public void PositiveTestForSubstracts()
        {
            Assert.AreEqual(new ComplexNumber(1, 0).ToString(), ((new ComplexNumber(2, 3))
                - (new ComplexNumber(1, 3))).ToString());
        }
        [TestMethod]
        public void NegativeTestForMultiplication()
        {
            Assert.AreNotEqual(new ComplexNumber(1.1, 0).ToString(), (new ComplexNumber(2.1, 3.2)
                - (new ComplexNumber(1.1, 3.2))).ToString());
        }
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void NegativeTestForNANInDivision()
        {
            Assert.AreEqual(1, new ComplexNumber(2, 3)/ (new ComplexNumber(0, 0)));
        }


    }
}
