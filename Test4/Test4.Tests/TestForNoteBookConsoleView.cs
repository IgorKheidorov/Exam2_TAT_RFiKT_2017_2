using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test4.Tests
{
  [TestClass]
  public class TestForNoteBookConsoleView
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestsException()
    {
      new NoteBookConsoleView().Print(new NoteBook("Name", new List<Note>(), new DateTime()), 2);
      new NoteBookConsoleView().Print(new NoteBook("Name", new List<Note>(), new DateTime()), 2, 3, 4);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestException()
    {
      new NoteBookConsoleView().Print(new NoteBook("", new List<Note>(), new DateTime()), 2);
      new NoteBookConsoleView().Print(new NoteBook("", new List<Note>(), new DateTime()), 2);
    }
  }
}
