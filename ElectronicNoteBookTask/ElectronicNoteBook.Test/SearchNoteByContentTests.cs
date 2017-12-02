using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElectronicNoteBookTask;

namespace ElectronicNoteBook.Test
{
    [TestClass]
    public class SearchNoteByContentTests
    {
        [TestMethod]
        public void SearchNotePositive()
        {
            Invoker invoker = new Invoker();
            NoteBook noteBook = new NoteBook();
            NoteBookProvider noteBookProvider = new NoteBookProvider();
            Note note = new Note();
            Note secondNote = new Note("mamapapa", "notfamily");
            string content = null;
            ICommand command = new SearchNoteByTheContentCommand(noteBookProvider, noteBook, content);
            invoker.SetCommand(command);
            invoker.Run();
            Assert.AreEqual("Title: \nValue: \nDate 01.01.0001 0:00:00", command.ToString());
        }
    }
}
