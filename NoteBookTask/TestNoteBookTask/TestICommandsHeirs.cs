using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteBookTask;

namespace TestNoteBookTask
{
    [TestClass]
    public class TestICommandsHeirs
    {
        [TestMethod]
        public void TestCreateNoteBook()
        {
            WorkerWithNoteBook worker = new WorkerWithNoteBook();
            NoteBookProvider provider = new NoteBookProvider();

            worker.SetCommand(new CreateNoteBook(provider));
            worker.Run();

            Assert.IsNotNull(provider.GetNoteBook());
        }

        [TestMethod]
        public void TestAddNote()
        {
            WorkerWithNoteBook worker = new WorkerWithNoteBook();
            NoteBookProvider provider = new NoteBookProvider();

            Note note = new Note();

            provider.CreateNoteBook();
            worker.SetCommand(new AddNote(provider, note));
            worker.Run();

            Assert.AreEqual(provider.GetNoteBook().Notes[0], note);
        }

        [TestMethod]
        public void TestFindNoteByContext()
        {
            WorkerWithNoteBook worker = new WorkerWithNoteBook();
            NoteBookProvider provider = new NoteBookProvider();

            Note note = new Note();
            note.Text = "abc";

            provider.CreateNoteBook();
            worker.SetCommand(new AddNote(provider, note));
            worker.Run();

            var finder = new FindNoteByContext(provider, "abc");
            worker.SetCommand(finder);
            worker.Run();

            Assert.IsNotNull(finder.FindedNote);
        }

        [TestMethod]
        public void TestFindNoteByContextNotFinded()
        {
            WorkerWithNoteBook worker = new WorkerWithNoteBook();
            NoteBookProvider provider = new NoteBookProvider();

            Note note = new Note();
            note.Text = "abc";

            provider.CreateNoteBook();
            worker.SetCommand(new AddNote(provider, note));
            worker.Run();

            var finder = new FindNoteByContext(provider, "def");
            worker.SetCommand(finder);
            worker.Run();

            Assert.IsNull(finder.FindedNote);
        }

        [TestMethod]
        public void TestFindNoteByCreatingData()
        {
            WorkerWithNoteBook worker = new WorkerWithNoteBook();
            NoteBookProvider provider = new NoteBookProvider();

            Note note = new Note();

            provider.CreateNoteBook();
            worker.SetCommand(new AddNote(provider, note));
            worker.Run();

            var finder = new FindNoteByCreatingData(provider, note.TimeOfCreating);
            worker.SetCommand(finder);
            worker.Run();

            Assert.IsNotNull(finder.FindedNote);
        }

        [TestMethod]
        public void TestFindNoteByCreatingDataNotFinded()
        {
            WorkerWithNoteBook worker = new WorkerWithNoteBook();
            NoteBookProvider provider = new NoteBookProvider();

            Note note = new Note();

            provider.CreateNoteBook();
            worker.SetCommand(new AddNote(provider, note));
            worker.Run();

            var finder = new FindNoteByCreatingData(provider, DateTime.Now);
            worker.SetCommand(finder);
            worker.Run();

            Assert.IsNull(finder.FindedNote);
        }
    }
}