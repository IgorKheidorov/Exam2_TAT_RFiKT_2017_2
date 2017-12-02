using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteBookSaturday;

namespace NoteBookSaturdayTest
{
    [TestClass]
    public class NoteTest
    {
        [TestMethod]
        public void TestEqualsEmptyNotes()
        {
            Assert.AreEqual(true, new Note().Equals(new Note()));
        }

        [TestMethod]
        public void TestEqualsEmptyTitleFilledRecordNotes()
        {
            Note one = new Note();
            one.record = "record";
            Note two = new Note();
            two.record = "record";
            Assert.AreEqual(true, one.Equals(two));
        }

        [TestMethod]
        public void TestGetHashCodeEmptyNotes()
        {
            Assert.AreEqual(true, new Note().GetHashCode() == new Note().GetHashCode());
        }

        [TestMethod]
        public void TestEqualsOneNoteEmpty()
        {
            Note one = new Note();
            one.record = "record";
            Assert.AreEqual(false, one.Equals(new Note()));
        }

        [TestMethod]
        public void TestEqualsTwoFullNotes()
        {
            Note one = new Note();
            one.record = "record1";
            one.title = "title1";
            Note two = new Note();
            two.record = "record2";
            one.title = "title2";
            Assert.AreEqual(false, one.Equals(two));
        }

    }
}
