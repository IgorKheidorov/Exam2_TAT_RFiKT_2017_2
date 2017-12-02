using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteBookTask;
using System.Text;

namespace TestNoteBookTask
{
    [TestClass]
    public class TestNoteBook
    {
        [TestMethod]
        public void TestEquals()
        {
            NoteBook notebook = new NoteBook();
            var secondNotebook = notebook;

            Assert.AreEqual(notebook, secondNotebook);
        }

        [TestMethod]
        public void TestEqualsDifferentCreatingTime()
        {
            NoteBook notebook = new NoteBook();
            notebook.TimeOfNoteBookCreating = DateTime.Now;
            var secondNotebook = new NoteBook();

            Assert.AreNotEqual(notebook, secondNotebook);
        }

        [TestMethod]
        public void TestEqualsDifferentName()
        {
            NoteBook notebook = new NoteBook();
            var secondNotebook = new NoteBook("Second notebook");

            Assert.AreNotEqual(notebook, secondNotebook);
        }

        [TestMethod]
        public void TestEqualsDifferentNotes()
        {
            Note note = new Note();
            var notebook = new NoteBook();
            notebook.Notes.Add(note);

            var secondNote = new Note();
            secondNote.Text = "It is second note";
            var secondNotebook = new NoteBook();
            notebook.Notes.Add(secondNote);

            Assert.AreNotEqual(notebook, secondNotebook);
        }

        [TestMethod]
        public void TestGetHashCode()
        {
            NoteBook notebook = new NoteBook();

            Assert.IsNotNull(notebook.GetHashCode());
        }

        [TestMethod]
        public void TestToString()
        {
            Note note = new Note();
            NoteBook nb = new NoteBook();
            nb.Notes.Add(note);

            StringBuilder builder = new StringBuilder();
            builder.Append(nb.NoteBookName + '\n');
            builder.Append(nb.TimeOfNoteBookCreating.ToString() + '\n');

            foreach (var n in nb.Notes)
            {
                builder.Append(n.ToString());
            }

            string text = builder.ToString();

            Assert.AreEqual(nb.ToString(), text);
        }
    }
}