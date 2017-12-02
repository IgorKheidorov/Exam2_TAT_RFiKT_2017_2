using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ElectronicNotepad.Tests
{
  [TestClass]
  public class NoteBookNegativeTests
  {
    [TestMethod]
    public void Equals_twoNoteBooksWithDifferentNames_falseValue()
    {
      Assert.AreEqual(false, new NoteBook("name1").Equals(new NoteBook("name2")));
    }

    [TestMethod]
    public void Equals_twoNotesWithDifferentCountOfNotes_falseValue()
    {
      Assert.AreEqual(false, new NoteBook("name", new List<Note>() { new Note("note1", "content1"),
        new Note("note2", "content2") }).Equals(new NoteBook("name", new List<Note>() { new Note("note3", "content3") })));
    }
  }
}