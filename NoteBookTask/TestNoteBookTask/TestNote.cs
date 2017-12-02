using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteBookTask;
using System.Text;

namespace TestNoteBookTask
{
    [TestClass]
    public class TestNote
    {
        [TestMethod]
        public void TestEquals()
        {
            Note note = new Note();
            var secondNote = note;

            Assert.AreEqual(note, secondNote);
        }

        [TestMethod]
        public void TestEqualsDifferentCreatingTime()
        {
            Note note = new Note();
            note.TimeOfCreating = DateTime.Now;
            var secondNote = new Note();

            Assert.AreNotEqual(note, secondNote);
        }

        [TestMethod]
        public void TestEqualsDifferentName()
        {
            Note note = new Note();
            var secondNote = new Note("Second note");

            Assert.AreNotEqual(note, secondNote);
        }

        [TestMethod]
        public void TestEqualsDifferentText()
        {
            Note note = new Note();
            var secondNote = new Note();
            secondNote.Text = "It is second note";

            Assert.AreNotEqual(note, secondNote);
        }
        
        [TestMethod]
        public void TestGetHashCode()
        {
            Note note = new Note();

            Assert.IsNotNull(note.GetHashCode());
        }
        
        [TestMethod]
        public void TestToString()
        {
            Note note = new Note();

            StringBuilder builder = new StringBuilder();
            builder.Append(note.Name + '\n');
            builder.Append(note.Text + '\n');
            builder.Append(note.TimeOfCreating);

            string text = builder.ToString();

            Assert.AreEqual(note.ToString(), text);
        }
    }
}