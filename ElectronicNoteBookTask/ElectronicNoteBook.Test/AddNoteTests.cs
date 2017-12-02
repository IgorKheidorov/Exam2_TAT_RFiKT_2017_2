using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElectronicNoteBookTask;

namespace ElectronicNoteBook.Test
{
    [TestClass]
    public class AddNoteTests
    {
        [TestMethod]
        public void AddNoteInNoteBookTitlePositive()
        {
            Invoker invoker = new Invoker();
            NoteBook noteBook = new NoteBook();
            NoteBookProvider noteBookProvider = new NoteBookProvider();
            Note note = new Note();
            invoker.SetCommand(new AddNoteCommand(noteBookProvider, noteBook, note));
            invoker.Run();
            Assert.AreEqual(null, noteBook.noteList[0].Title);
        }

        [TestMethod]
        public void AddNoteInNoteBookValuePositive()
        {
            Invoker invoker = new Invoker();
            NoteBook noteBook = new NoteBook();
            NoteBookProvider noteBookProvider = new NoteBookProvider();
            Note note = new Note();
            invoker.SetCommand(new AddNoteCommand(noteBookProvider, noteBook, note));
            invoker.Run();
            Assert.AreEqual(null, noteBook.noteList[0].Value);
        }

        [TestMethod]
        public void AddNoteInNoteBookPositive()
        {
            Invoker invoker = new Invoker();
            NoteBook noteBook = new NoteBook();
            NoteBookProvider noteBookProvider = new NoteBookProvider();
            Note note = new Note("title", "value");
            invoker.SetCommand(new AddNoteCommand(noteBookProvider, noteBook, note));
            invoker.Run();
            Assert.AreEqual("title", noteBook.noteList[0].Value);
        }


    }
}
