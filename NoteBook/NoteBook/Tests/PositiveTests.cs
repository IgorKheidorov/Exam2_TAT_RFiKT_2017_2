using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notebook;

namespace Tests
{
  [TestClass]
  public class PositiveTests
  {
    [TestMethod]
    public void TestOfCreatingNewNoteBook()
    {
      NoteBook noteBook = new NoteBook();
      noteBook.CreateNoteBook();
      Assert.IsNotNull(noteBook.Notes);
    }
    [TestMethod]
    public void TestAddNote()
    {
      NoteBook noteBook = new NoteBook();
      noteBook.CreateNoteBook();
      noteBook.AddNote("example","title");
      Assert.AreEqual(noteBook.Notes[0].Value,"example");
      Assert.AreEqual(noteBook.Notes[0].Title,"title");
    }
    [TestMethod]
    public void TestSearchByValue()
    {
      NoteBook noteBook = new NoteBook();
      noteBook.CreateNoteBook();
      noteBook.AddNote("example", "title");
      noteBook.AddNote("123", "456");
      noteBook.AddNote("234", "345");
      Note result = noteBook.SearchByValue("123");
      Assert.AreEqual("123",result.Value);
      Assert.AreEqual("456",result.Title);
    }
    [TestMethod]
    public void TestSearchByDate()
    {
      NoteBook noteBook = new NoteBook();
      noteBook.CreateNoteBook();
      noteBook.AddNote("example", "title",new DateTime(1000,6,1));
      noteBook.AddNote("123", "456", new DateTime(1500, 9, 2));
      noteBook.AddNote("234", "345");
      Note result = noteBook.SearchByTimeOfCreation(new DateTime(1500, 9, 2));
      Assert.AreEqual("123", result.Value);
      Assert.AreEqual("456", result.Title);
      Assert.AreEqual(new DateTime(1500, 9, 2), result.timeOfCreation);
    }


  }
}
