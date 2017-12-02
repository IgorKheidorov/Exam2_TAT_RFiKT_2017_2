using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteBookSaturday;

namespace NoteBookSaturdayTest
{
    [TestClass]
    public class NoteBookTest
    {
        [TestMethod]
        public void TestAdd()
        {
            NoteBook noteBook = new NoteBook("My notebook.");
            noteBook.Add("record");
            Assert.AreEqual("record", noteBook.GetCurrentNote().record);
        }

        [TestMethod]
        public void TestDeleteNoteByRecord()
        {
            NoteBook noteBook = new NoteBook("My notebook.");
            noteBook.Add("record1");
            noteBook.Add("record2");
            noteBook.DeleteNoteByRecord("record1");
            noteBook.MoveStart();
            Assert.AreEqual("record2", noteBook.GetCurrentNote().record);
        }
    }
}
