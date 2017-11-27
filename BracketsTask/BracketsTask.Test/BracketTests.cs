using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BracketsTask.Test
{
    [TestClass]
    public class BracketTests
    {
        [TestMethod]
        public void IsValidWithCorrectPositive()
        {
            Assert.IsTrue(new Brackets().IsValid("([{}])"));
        }

        [TestMethod]
        public void IsValidWithAllRoundBracketsPositive()
        {
            Assert.IsTrue(new Brackets().IsValid("(())"));
        }

        [TestMethod]
        public void IsValidWithNotValidPositionBracketsString()
        {
            Assert.IsFalse(new Brackets().IsValid("([{])}"));
        }
        [TestMethod]
        public void IsValidWithStringWithoutBrackets()
        {
            Assert.IsFalse(new Brackets().IsValid("111"));
        }
    }
}
