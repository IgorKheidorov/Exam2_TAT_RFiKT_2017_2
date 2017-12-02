using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scratchpad;

namespace UnitTests
{
  [TestClass]
  public class UnitTests
  {
    [TestMethod]
    public void TestCreateNewNote()
    {
      NoteBook notebook = new NoteBook();
      notebook.CreateNewNoteBook("BSU");

      Assert.AreEqual(1, notebook.Count);
    }

    [TestMethod]
    public void TestAddNewNote()
    {
      NoteBook notebook = new NoteBook();
      notebook.CreateNewNoteBook("BSU");
      notebook.AddNewNote("Yale");

      Assert.AreEqual(2, notebook.Count);
    }

    [TestMethod]
    public void TestFindNoteByValue()
    {
      NoteBook notebook = new NoteBook();
      notebook.AddNewNote("BSU");
      notebook.AddNewNote("BSU2");
      notebook.AddNewNote("BSU3");
      Assert.AreNotEqual("BSU2 17.09.2017", notebook.FindNoteByValue("BSU2"));
    }

    [TestMethod]
    public void TestNoteEqualse()
    {
      Note note1 = new Note("1234", new DateTime(2031,03,11));
      Note note2 = new Note("1234", new DateTime(2031, 03, 11));
      Assert.AreEqual(true, note1.Equals(note2));
    }

    [TestMethod]
    public void TestInvoker()
    {
      NoteBook notebook = new NoteBook();
      InvokerNoteBookProvider invoker = new InvokerNoteBookProvider();

      invoker.SetCommand(new CommandCreateNewNoteBook(notebook, "123"));
      invoker.Run();

      invoker.SetCommand(new CommandAddNewNoteToNoteBook(notebook, "456"));
      invoker.Run();

      Assert.AreEqual(2, notebook.Count);
    }
  }
}
