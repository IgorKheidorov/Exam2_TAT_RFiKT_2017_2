using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ElectronicNotepad.Tests
{
  [TestClass]
  public class NoteBookPositiveTests
  {
    [TestMethod]
    public void Equals_twoNoteBooksWithEqualNames_trueValue()
    {
      Assert.AreEqual(true, new NoteBook("name").Equals(new NoteBook("name")));
    }

    [TestMethod]
    public void Equals_twoNoteBooksWithEqualContents_trueValue()
    {
      Assert.AreEqual(true, new NoteBook("name", new List<Note>() { new Note("note1", "content1"),
        new Note("note2", "content2") }).Equals(new NoteBook("name", new List<Note>() { new Note("note1", "content1"),
        new Note("note2", "content2") })));
    }
  }
}
