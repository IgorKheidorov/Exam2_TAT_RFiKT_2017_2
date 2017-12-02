using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElectronicNoteBookTask;

namespace ElectronicNoteBook.Test
{
    [TestClass]
    public class NoteBookTests
    {
        [TestMethod]
        public void CreateNoteBookPositive()
        {
            Assert.AreEqual(null, new NoteBook().Title);
        }

        [TestMethod]
        public void CreateNoteBookWithTitlePositive()
        {
            NoteBook noteBook = new NoteBook("title");
            Assert.AreEqual("title", noteBook.Title);
        }

        [TestMethod]
        public void ToStringNoteBookNegative()
        {
            Assert.AreNotEqual("11", new NoteBook().ToString());
        }

        [TestMethod]
        public void ToStringNoteBookPositive()
        {
            Assert.AreEqual("Title: \nDate 01.01.0001 0:00:00", new NoteBook().ToString());
        }

        [TestMethod]
        public void EqualsNoteBookPositive()
        {
            NoteBook note1 = new NoteBook();
            NoteBook note2 = new NoteBook();
            Assert.IsTrue(note1.Equals(note2));
        }

        [TestMethod]
        public void NotEqualsNoteBookPositive()
        {
            NoteBook note1 = new NoteBook();
            NoteBook note2 = new NoteBook("title");
            Assert.IsFalse(note1.Equals(note2));
        }
        
        [TestMethod]
        public void EqualsNoteBookNegative()
        {
            NoteBook note1 = new NoteBook();
            Object note2 = new Note();
            Assert.IsFalse(note1.Equals(note2));
        }

        [TestMethod]
        public void GetHashCodeNoteBookPositive()
        {
            NoteBook note1 = new NoteBook("title");
            NoteBook note2 = new NoteBook("title");
            Assert.AreEqual(note1.GetHashCode(), note2.GetHashCode());
        }

        [TestMethod]
        public void GetHashCodeNotEqualNoteBookPositive()
        {
            NoteBook note1 = new NoteBook("1");
            NoteBook note2 = new NoteBook("title");
            Assert.AreNotEqual(note1.GetHashCode(), note2.GetHashCode());
        }

        [TestMethod]
        public void GetHashCodeNoteBookNegative()
        {
            NoteBook note1 = new NoteBook("title");
            Object note2 = new Note("1", "1");
            Assert.AreNotEqual(note1.GetHashCode(), note2.GetHashCode());
        }
    }
}
