using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElectronicNotepad.Tests
{
  [TestClass]
  public class NoteNegativeTests
  {
    [TestMethod]
    public void Equals_twoNotesWithDifferentNames_falseValue()
    {
      Assert.AreEqual(false, new Note("name1", "content").Equals(new Note("name2", "content")));
    }

    [TestMethod]
    public void Equals_twoNotesWithDifferentContents_falseValue()
    {
      Assert.AreEqual(false, new Note("name", "content1").Equals(new Note("name", "content2")));
    }

    [TestMethod]
    public void GetHashCode_twoNotesWithDifferentNames_notEqualHashCodeValues()
    {
      Assert.AreEqual(false, new Note("name1", "content").GetHashCode().Equals(new Note("name2", "content").GetHashCode()));
    }

    [TestMethod]
    public void GetHashCode_twoNotesWithDifferentContents_notEqualHashCodeValues()
    {
      Assert.AreEqual(false, new Note("name", "content1").GetHashCode().Equals(new Note("name", "content2").GetHashCode()));
    }
  }
}
