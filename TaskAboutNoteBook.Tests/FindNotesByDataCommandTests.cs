using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskAboutNoteBook.Tests
{
  [TestClass]
  public class FindNotesByDataCommandTests
  {
    NoteBookProvider provider = new NoteBookProvider();
    NoteProvider noteProvider = new NoteProvider();

    [TestMethod]
    public void TestFindNotesByData()
    {
      provider.CreateNoteBook();
      provider.NoteBook.AddNote(noteProvider.GetNote());
      FindNotesByDataCommand command = new FindNotesByDataCommand(provider);
      List<Note> listOfNotes = new List<Note>();
      listOfNotes.Add(noteProvider.GetNote());
      Assert.AreEqual( listOfNotes,command.FindNotesByData("data"));
    }
  }
}
