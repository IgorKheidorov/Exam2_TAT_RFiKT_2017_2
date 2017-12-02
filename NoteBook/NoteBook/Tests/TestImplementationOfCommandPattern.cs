using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notebook;
using Notebook.CommandImplementation;
namespace Tests
{
  [TestClass]
  public class TestImplementationOfCommandPattern
  {
    [TestMethod]
    public void TestCreateNoteBook()
    {
      NoteBook noteBook = new NoteBook();
      NoteBookProvider provider = new NoteBookProvider();
      provider.SetCommand(new CreateNoteBook(noteBook));
      provider.Run();
      Assert.IsNotNull(noteBook.Notes);
    }
    [TestMethod]
    public void TestAddNote()
    {
      NoteBook noteBook = new NoteBook();
      NoteBookProvider provider = new NoteBookProvider();
      provider.SetCommand(new CreateNoteBook(noteBook));
      provider.Run();
      provider.SetCommand(new AddNote(noteBook, "abc", "title"));
      provider.Run();
      Assert.AreEqual("abc", noteBook.Notes[0].Value);
      Assert.AreEqual("title", noteBook.Notes[0].Title);
    }
    [TestMethod]
    public void TestSearchByTimeOfCreation()
    {
      NoteBook noteBook = new NoteBook();
      NoteBookProvider provider = new NoteBookProvider();
      provider.SetCommand(new CreateNoteBook(noteBook));
      provider.Run();
      provider.SetCommand(new AddNote(noteBook, "abc", "title"));
      provider.Run();
      provider.SetCommand(new AddNote(noteBook, "cde", "title2"));
      provider.Run();
      provider.SetCommand(new AddNote(noteBook, "dfg", "title3"));
      provider.Run();
      SearchByValue searcher = new SearchByValue(noteBook, "cde");
      provider.SetCommand(searcher);
      provider.Run();
      Assert.AreEqual("cde", searcher.GetResult().Value);
      Assert.AreEqual("title2", searcher.GetResult().Title);
    }
  }
}
