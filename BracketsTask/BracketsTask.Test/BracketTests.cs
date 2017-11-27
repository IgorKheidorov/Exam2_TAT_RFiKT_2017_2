﻿using System;
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
        public void IsValidWithNotValidPositionBracketsNegative()
        {
            Assert.IsFalse(new Brackets().IsValid("([{])}"));
        }
        [TestMethod]
        public void IsValidWithStringWithoutBracketsNegative()
        {
            Assert.IsFalse(new Brackets().IsValid("111"));
        }

        [TestMethod]
        public void IsValidWithStringWithCloseBracketMoreThanOPenBracketsNegative()
        {
            Assert.IsFalse(new Brackets().IsValid("()))"));
        }

        [TestMethod]
        public void IsValidWithNotDataAfterTheBracketsPositive()
        {
            Assert.IsFalse(new Brackets().IsValid("()1111"));
        }
        [TestMethod]
        public void IsValidWithNotDataInTheCenterOfTheBracketsPositive()
        {
            Assert.IsFalse(new Brackets().IsValid("()1111"));
        }
    }
}
