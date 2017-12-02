using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElectronicNotebook;

namespace NotebookTest
{
    [TestClass]
    public class NoteBookTest
    {
        [TestMethod]
        public void PositiveTestMethodForEqualsNote()
        {
            Assert.IsTrue(new Note("bla", "bla").Equals(new Note("bla", "bla")));
        }
        [TestMethod]
        public void NegativeTestMethodForEqualsNote()
        {
            Assert.IsFalse(new Note("bla", "bla").Equals(new Note("bl", "bla")));
        }
        [TestMethod]
        public void PositiveTestMethodForToStringNote()
        {
            Note note = new Note("bla", "bla");
            Assert.AreEqual("bla/nbla/n" + note.Date.ToString() +"/n",
                note.ToString());
        }
        [TestMethod]
        public void NegativeTestMethodForToStringNote()
        {
            Assert.AreNotEqual("bla", new Note("bla", "bla").ToString());
        }
        [TestMethod]
        public void PositiveTestMethodForEqualsNoteBook()
        {
            Assert.AreEqual(true, new NoteBook("bl").Equals(new NoteBook("bl")));
        }
        [TestMethod]
        public void NegativeTestMethodForEqualsNoteBook()
        {
            Assert.IsFalse(new NoteBook("bl").Equals(new NoteBook("bla")));
        }
        [TestMethod]
        public void NegativeTestNoteForGetHashCode()
        {
            Assert.AreNotEqual(new Note("bla", "bla").GetHashCode(),
                new Note("bla", "bla").GetHashCode());
        }
        [TestMethod]
        public void NegativeTestMethodForToStringNoteBook()
        {
            Assert.AreNotEqual("bla", new NoteBook("bla").ToString());
        }
        [TestMethod]
        public void NegativeTestNoteBookForGetHashCode()
        {
            Assert.AreNotEqual(new NoteBook("bl").GetHashCode(),
                new NoteBook("bla").GetHashCode());
        }
        [TestMethod]
        public void PositiveTestForCreatingNotebook()
        {
            IProvidable noteProvidable = new ValueReader();
            NoteBookEditor editor = new NoteBookEditor();
            NoteBookReceiver rec = new NoteBookReceiver(noteProvidable);
            editor.SetCommand(new CreateNoteBookCommand(rec));
            editor.Run();
            Assert.IsTrue(rec.notebook.Title != null);
        }
        [TestMethod]
        public void PositiveTestForAddingNote()
        {
            IProvidable noteProvidable = new ValueReader();
            NoteBookEditor editor = new NoteBookEditor();
            NoteBookReceiver rec = new NoteBookReceiver(noteProvidable);
            editor.SetCommand(new AddNotesCommand(rec, new Note("bla", "bla")));
            editor.Run();
            Assert.IsTrue(rec.notebook.Notes.Count != null);
        }

        [ExpectedException(typeof(System.NullReferenceException))]
        [TestMethod]
        public void NegativeTestForFindingNote()
        {
            IProvidable noteProvidable = new ValueReader();
            NoteBookEditor editor = new NoteBookEditor();
            NoteBookReceiver rec = new NoteBookReceiver(noteProvidable);
            editor.SetCommand(new FindByContextCommand(rec, "bla"));
            editor.Run();
        }
        [ExpectedException(typeof(System.NullReferenceException))]
        [TestMethod]
        public void NegativeTestForFindingNoteByDate()
        {
            IProvidable noteProvidable = new ValueReader();
            NoteBookEditor editor = new NoteBookEditor();
            NoteBookReceiver rec = new NoteBookReceiver(noteProvidable);
            editor.SetCommand(new FindByDateCommand(rec, DateTimeOffset.Now));
            editor.Run();
        }
        [ExpectedException(typeof(System.NullReferenceException))]
        [TestMethod]
        public void NegativeTestForShowingAllValue()
        {
            IProvidable noteProvidable = new ValueReader();
            NoteBookEditor editor = new NoteBookEditor();
            NoteBookReceiver rec = new NoteBookReceiver(noteProvidable);
            editor.SetCommand(new ShowNotesCommand(rec));
            editor.Run();
        }
    }
}
