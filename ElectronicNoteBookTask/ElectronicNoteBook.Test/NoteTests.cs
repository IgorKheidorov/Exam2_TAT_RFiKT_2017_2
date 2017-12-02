using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElectronicNoteBookTask;

namespace ElectronicNoteBook.Test
{
    [TestClass]
    public class NoteTests
    {
        [TestMethod]
        public void CreateNotePositive()
        {
            Assert.AreEqual(null, new Note().Title);
        }

        [TestMethod]
        public void CreateNoteBookWithTitlePositive()
        {
            Note note = new Note("title", "value");
            Assert.AreEqual("title", note.Title);
        }

        [TestMethod]
        public void CreateNoteBookWithValuePositive()
        {
            Note note = new Note("title", "value");
            Assert.AreEqual("value", note.Value);
        }

        [TestMethod]
        public void ToStringNoteNegative()
        {
            Assert.AreNotEqual("11", new Note().ToString());
        }

        [TestMethod]
        public void ToStringNotePositive()
        {
            Assert.AreEqual("Title: \nValue: \nDate 01.01.0001 0:00:00", new Note().ToString());
        }

        [TestMethod]
        public void EqualsNotePositive()
        {
            Note note1 = new Note();
            Note note2 = new Note();
            Assert.IsTrue(note1.Equals(note2));
        }

        [TestMethod]
        public void NotEqualsNotePositive()
        {
            Note note1 = new Note();
            Note note2 = new Note("title", "value");
            Assert.IsFalse(note1.Equals(note2));
        }

        [TestMethod]
        public void EqualsNoteNegative()
        {
            Note note1 = new Note();
            Object note2 = new NoteBook();
            Assert.IsFalse(note1.Equals(note2));
        }

        [TestMethod]
        public void GetHashCodeNotePositive()
        {
            Note note1 = new Note("title", "value");
            Note note2 = new Note("title", "value");
            Assert.AreEqual(note1.GetHashCode(), note2.GetHashCode());
        }

        [TestMethod]
        public void GetHashCodeNotEqualNotePositive()
        {
            Note note1 = new Note("1", "value");
            Note note2 = new Note("title", "value");
            Assert.AreNotEqual(note1.GetHashCode(), note2.GetHashCode());
        }

        [TestMethod]
        public void GetHashCodeNoteNegative()
        {
            Note note1 = new Note("title", "value");
            Object note2 = new NoteBook("title");
            Assert.AreNotEqual(note1.GetHashCode(), note2.GetHashCode());
        }
    }
}
