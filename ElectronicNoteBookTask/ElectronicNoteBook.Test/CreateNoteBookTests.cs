using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElectronicNoteBookTask;

namespace ElectronicNoteBook.Test
{
    [TestClass]
    public class CreateNoteBookTests
    {
        [TestMethod]
        public void CreateNoteBookPositive()
        {
            Invoker invoker = new Invoker();
            NoteBook noteBook = new NoteBook();
            NoteBookProvider noteBookProvider = new NoteBookProvider();
            invoker.SetCommand(new CreateNoteBookCommand(noteBookProvider, noteBook));
            invoker.Run();
            Assert.AreEqual(null, noteBook.Title);
        }

        [TestMethod]
        public void CreateNoteBookTitlePositive()
        {
            Invoker invoker = new Invoker();
            NoteBook noteBook = new NoteBook("title");
            NoteBookProvider noteBookProvider = new NoteBookProvider();
            invoker.SetCommand(new CreateNoteBookCommand(noteBookProvider, noteBook));
            invoker.Run();
            Assert.AreEqual("title", noteBook.Title);
        }

        [TestMethod]
        public void CreateNoteBookDatePositive()
        {
            Invoker invoker = new Invoker();
            NoteBook noteBook = new NoteBook("title");
            NoteBookProvider noteBookProvider = new NoteBookProvider();
            invoker.SetCommand(new CreateNoteBookCommand(noteBookProvider, noteBook));
            invoker.Run();
            Assert.AreNotEqual("", noteBook.Date.ToString());
        }

    }
}
