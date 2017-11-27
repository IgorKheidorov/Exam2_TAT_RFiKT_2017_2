using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskAboutBrackets.Tests
{
    [TestClass]
    public class StringValidatorTests
    {
        StringValidator validator = new StringValidator();
        [TestMethod]
        public void TestStringIsValidOnValidAlignmentWithEmbeddedBracketsWithAllTypesOfBrackets()
        {
            Assert.IsTrue(validator.StringIsValid("{ [ ( ) ] }"));
        }

        [TestMethod]
        public void TestStringIsValidOnValidAlignmentWithBraces()
        {
            Assert.IsTrue(validator.StringIsValid("{ }"));
        }

        [TestMethod]
        public void TestStringIsValidOnValidAlignmentWithRoundBrackets()
        {
            Assert.IsTrue(validator.StringIsValid("( )"));
        }


        [TestMethod]
        public void TestStringIsValidOnValidAlignmentWithSquareBrackets()
        {
            Assert.IsTrue(validator.StringIsValid("[ ]"));
        }


        [TestMethod]
        public void TestStringIsValidOnValidConsistentAlignmentWithAllTypesOfBrackets()
        {
            Assert.IsTrue(validator.StringIsValid("{ }[ ]( )"));
        }

        [TestMethod]
        public void TestStringIsValidOnInvalidAlignmentWithBracesAndRoundBrackets()
        {
            Assert.IsFalse(validator.StringIsValid("{ ( } ) "));
        }

        [TestMethod]
        public void TestStringIsValidOnInvalidAlignmentWithBracesAndSquareBrackets()
        {
            Assert.IsFalse(validator.StringIsValid("{ [ } ] "));
        }

        [TestMethod]
        public void TestStringIsValidOnClosingBracketInTwoRoundBracketsWithRightAlignement()
        {
            Assert.IsFalse(validator.StringIsValid(" ( ) ) "));
        }

        [TestMethod]
        public void TestStringIsValidOnClosingBracketInTwoSquareBracketsWithRightAlignement()
        {
            Assert.IsFalse(validator.StringIsValid(" [ ] ] "));
        }

        [TestMethod]
        public void TestStringIsValidOnClosingBracketInTwoBracesWithRightAlignement()
        {
            Assert.IsFalse(validator.StringIsValid(" { } } "));
        }

     

        [TestMethod]
        public void TestStringIsValidOnOneClosingBrace()
        {
            Assert.IsFalse(validator.StringIsValid(" } "));
        }

        [TestMethod]
        public void TestStringIsValidOnOneClosingSquareBracket()
        {
            Assert.IsFalse(validator.StringIsValid(" ] "));
        }

        [TestMethod]
        public void TestStringIsValidOnOneClosingRoundBracket()
        {
            Assert.IsFalse(validator.StringIsValid(" ) "));
        }

        [TestMethod]
        public void TestStringIsValidOnOneOpeningRoundBracket()
        {
            Assert.IsFalse(validator.StringIsValid(" ( "));
        }

        [TestMethod]
        public void TestStringIsValidOnOneOpeningSquareBracket()
        {
            Assert.IsFalse(validator.StringIsValid(" [ "));
        }

        [TestMethod]
        public void TestStringIsValidOnOneOpeningBrace()
        {
            Assert.IsFalse(validator.StringIsValid(" { "));
        }
    }
}
