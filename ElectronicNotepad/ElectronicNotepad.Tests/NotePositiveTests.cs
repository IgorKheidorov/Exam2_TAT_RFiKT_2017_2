using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElectronicNotepad.Tests
{
  [TestClass]
  public class NotePositiveTests
  {
    [TestMethod]
    public void Equals_twoEqualNotes_trueValue()
    {
      Assert.AreEqual(true, new Note("name", "content").Equals(new Note("name", "content")));
    }

    [TestMethod]
    public void GetHashCode_twoEqualNotes_equalHashCodeValues()
    {
      Assert.AreEqual(true, new Note("name", "content").GetHashCode().Equals(new Note("name", "content").GetHashCode()));
    }
  }
}