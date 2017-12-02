using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElectronicNoteBook;

namespace ReceiverTest
{
  [TestClass]
  public class ReceiverTest
  {
    [TestMethod]
    public void TestAddNoteToNoteBook()
    {
      //NoteBook notebook = new NoteBook();
      DateTime dateTime = DateTime.Now;
      StringBuilder text = new StringBuilder("new text");
      Note note = new Note(dateTime, text);
      NoteBook notebook = new NoteBook(0, DateTime.Now);
      List<Note> listOfNotes = new List<Note>();
      listOfNotes.Add(note);
      notebook.Notations = listOfNotes;
      Assert.AreEqual(dateTime, notebook.Notations[0].DateOfCreation);
      Assert.AreEqual(0, notebook.Id);
    }
  }
}
