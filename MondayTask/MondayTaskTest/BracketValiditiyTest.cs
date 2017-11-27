using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MondayTask;

namespace MondayTaskTest
{
    [TestClass]
    public class BracketValiditiyTest
    {
        [TestMethod]
        public void PositiveTestForValidityExpressionWithAllBrackets()
        {
            Assert.AreEqual(true, new BracketValidator().IsValidArrangment("({[]})"));
        }
        [TestMethod]
        public void PositiveTestForValidityForSquareBrackets()
        {
            Assert.AreEqual(true, new BracketValidator().IsValidArrangment("[]"));
        }
        [TestMethod]
        public void PositiveTestForValidityForRoundBrackets()
        {
            Assert.AreEqual(true, new BracketValidator().IsValidArrangment("()"));
        }
        [TestMethod]
        public void PositiveTestForValidityForCurlyBrackets()
        {
            Assert.AreEqual(true, new BracketValidator().IsValidArrangment("{}"));
        }
        [TestMethod]
        public void NegativeTestForValidityForEmpty()
        {
            Assert.AreEqual(true, new BracketValidator().IsValidArrangment(""));
        }
        [TestMethod]
        public void NegativeTestForValidityForOneCurlyBracket()
        {
            Assert.AreEqual(false, new BracketValidator().IsValidArrangment("{"));
        }
        [TestMethod]
        public void NegativeTestForValidityForOneSquareBracket()
        {
            Assert.AreEqual(false, new BracketValidator().IsValidArrangment("["));
        }
        [TestMethod]
        public void NegativeTestForValidityForOneRoundBracket()
        {
            Assert.AreEqual(false, new BracketValidator().IsValidArrangment("("));
        }
        [TestMethod]
        public void NegativeTestForValidityForOneCloseCurlyBracket()
        {
            Assert.AreEqual(false, new BracketValidator().IsValidArrangment("}"));
        }
        [TestMethod]
        public void NegativeTestForValidityForOneCloseSquareBracket()
        {
            Assert.AreEqual(false, new BracketValidator().IsValidArrangment("]"));
        }
        [TestMethod]
        public void NegativeTestForValidityForOneCloseRoundBracket()
        {
            Assert.AreEqual(false, new BracketValidator().IsValidArrangment(")"));
        }
        [TestMethod]
        public void NegativeTestForValidityThreeEqualsBrackets()
        {
            Assert.AreEqual(false, new BracketValidator().IsValidArrangment("((("));
        }
        [TestMethod]
        public void NegativeTestForValidityTwoPairsAndOneBracketWithoutPair()
        {
            Assert.AreEqual(false, new BracketValidator().IsValidArrangment("{([)}"));
        }
        [TestMethod]
        public void PositiveTestForValidityOneInnerPairAndTwoOutter()
        {
            Assert.AreEqual(true, new BracketValidator().IsValidArrangment("{}([])"));
        }
        [TestMethod]
        public void NegativeTestForWrongBracketArrangment()
        {
            Assert.AreEqual(false, new BracketValidator().IsValidArrangment("{}[])"));
        }
        [TestMethod]
        public void NegativeTestForWrongBracketArrangmentTwoUnnessesaryBrackets()
        {
            Assert.AreEqual(false, new BracketValidator().IsValidArrangment("{}[])"));
        }
        [TestMethod]
        public void PositiveTestForValidArranmentWithNumbers()
        {
            Assert.AreEqual(true, new BracketValidator().IsValidArrangment("{12 + 3} -[2 + 1]"));
        }
        [TestMethod]
        public void NegativeTestForValidArranmentWithNumbers()
        {
            Assert.AreEqual(false, new BracketValidator().IsValidArrangment("{12 + 3} )-[2 + 1]"));
        }
        [TestMethod]
        public void PositiveTestForValidArranmentNumbersBeforeBrackets()
        {
            Assert.AreEqual(true, new BracketValidator().IsValidArrangment("123(){}[]"));
        }
        [TestMethod]
        public void PositiveTestForValidArranmentNumbersAfterBrackets()
        {
            Assert.AreEqual(true, new BracketValidator().IsValidArrangment("(){}[]23"));
        }
        [TestMethod]
        public void PositiveTestForValidArranmentWithSpaces()
        {
            Assert.AreEqual(true, new BracketValidator().IsValidArrangment("(   () ) []"));
        }
        [TestMethod]
        public void NegativeTestForArrangmentWithFirstCloseBracket()
        {
            Assert.AreEqual(false, new BracketValidator().IsValidArrangment("}((("));
        }
        [TestMethod]
        public void NegativeTestForArrangmentWithNumbers()
        {
            Assert.AreEqual(false, new BracketValidator().IsValidArrangment("45{}["));
        }
        [TestMethod]
        public void NegativeTestForArrangmentRandomAmountOfBrackets()
        {
            Assert.AreEqual(false, new BracketValidator().IsValidArrangment("}{}{{]{]{]{]{}{}{}"));
        }
    }
}
