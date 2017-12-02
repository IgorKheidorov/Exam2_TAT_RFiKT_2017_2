using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteBookTask;

namespace TestNoteBookTask
{
    [TestClass]
    public class TestNoteBookProvider
    {
        [TestMethod]
        public void TestCreateNoteBook()
        {
            NoteBookProvider provider = new NoteBookProvider();

            Assert.IsNotNull(provider.CreateNoteBook());
        }

        [TestMethod]
        public void TestAddNote()
        {
            NoteBookProvider provider = new NoteBookProvider();
            provider.CreateNoteBook();

            Note note = new Note();
            provider.AddNote(note);
            Assert.AreEqual(provider.GetNoteBook().Notes[0], note);
        }

        [TestMethod]
        public void TestFindNoteByContext()
        {
            NoteBookProvider provider = new NoteBookProvider();
            provider.CreateNoteBook();

            Note note = new Note();
            note.Text = "abc";
            provider.AddNote(note);
            
            Assert.AreEqual(provider.FindNoteByContext("abc"), note);
        }

        [TestMethod]
        public void TestFindNoteByContextNotFinded()
        {
            NoteBookProvider provider = new NoteBookProvider();
            provider.CreateNoteBook();

            Note note = new Note();
            provider.AddNote(note);
            note.Text = "abc";
            provider.AddNote(note);

            Assert.AreNotEqual(provider.FindNoteByContext("def"), note);
        }

        [TestMethod]
        public void TestFindNoteByCreatingData()
        {
            NoteBookProvider provider = new NoteBookProvider();
            provider.CreateNoteBook();

            Note note = new Note();
            provider.AddNote(note);

            Assert.AreEqual(provider.FindNoteByCreatingData(note.TimeOfCreating), note);
        }

        [TestMethod]
        public void TestFindNoteByCreatingDataNotFinded()
        {
            NoteBookProvider provider = new NoteBookProvider();
            provider.CreateNoteBook();

            Note note = new Note();
            provider.AddNote(note);

            Assert.AreNotEqual(provider.FindNoteByCreatingData(DateTime.Now), note);
        }
    }
}