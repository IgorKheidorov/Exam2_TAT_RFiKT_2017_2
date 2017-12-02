using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notebook;


namespace Tests
{
  [TestClass]
  public class NegativeTests
  {
    [TestMethod]
    public void TestSearchNonexistentValue()
    {
      NoteBook noteBook = new NoteBook();
      noteBook.CreateNoteBook();
      noteBook.AddNote("example", "title");
      noteBook.AddNote("123", "456");
      noteBook.AddNote("234", "345");
      Note result = noteBook.SearchByValue("666");
      Assert.AreEqual(null, result);
    }
    [TestMethod]
    public void TestSearchNonexistentDate()
    {
      NoteBook noteBook = new NoteBook();
      noteBook.CreateNoteBook();
      noteBook.AddNote("example", "title", new DateTime(1000, 6, 1));
      noteBook.AddNote("123", "456", new DateTime(1500, 9, 2));
      noteBook.AddNote("234", "345");
      Note result = noteBook.SearchByTimeOfCreation(new DateTime(1337, 2, 28));
      Assert.AreEqual(null,result);
    }
  }
}
