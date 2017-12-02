using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test4.Tests
{
  [TestClass]
  public class TestsForNoteBook
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestsException()
    {
      new NoteBook("", new List<Note>(), new DateTime());
    }

    [TestMethod]
    public void PositiveTestTostring()
    {
      Assert.AreEqual("Name of notebook: Name, date of creation: 31.12.2012 0:00:00", new NoteBook("Name", new List<Note>(), new DateTime(2012, 12, 31)).ToString());
    }

    [TestMethod]
    public void NegativeTestTostring()
    {
      Assert.AreNotEqual("Name of notebook: Name, date of creation: 31.12.2012 0:00:00", new NoteBook("Name1", new List<Note>(), new DateTime(2012, 12, 31)).ToString());
      Assert.AreNotEqual("Name of notebook: Name, date of creation: 31.12.2012 0:00:00", new NoteBook("Name", new List<Note>(), new DateTime(2012, 12, 21)).ToString());
    }

    [TestMethod]
    public void PositiveTestEquals()
    {
      List<Note> list = new List<Note>();
      Assert.IsTrue(new NoteBook("Name", list, new DateTime(1, 2, 3)).Equals(new NoteBook("Name", list, new DateTime(1, 2, 3))));
    }

    [TestMethod]
    public void NegativeTestEquals()
    {
      List<Note> firstList = new List<Note>();
      List<Note> secondList = new List<Note>();
      secondList.Add(new Note("1", "2", new DateTime()));
      Assert.IsFalse(new NoteBook("Name1", firstList, new DateTime(1, 2, 3)).Equals(new NoteBook("Name", firstList, new DateTime(1, 2, 3))));
      Assert.IsFalse(new NoteBook("Name", firstList, new DateTime(1, 2, 3)).Equals(new NoteBook("Name", secondList, new DateTime(1, 2, 3))));
      Assert.IsFalse(new NoteBook("Name", firstList, new DateTime(1, 2, 3)).Equals(new NoteBook("Name", firstList, new DateTime(3, 4, 5))));
      Assert.IsFalse(new NoteBook("Name1", firstList, new DateTime(1, 2, 3)).Equals("abc"));
    }
  }
}
