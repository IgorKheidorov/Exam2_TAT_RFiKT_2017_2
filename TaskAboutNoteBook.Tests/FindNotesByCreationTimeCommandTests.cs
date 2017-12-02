using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskAboutNoteBook.Tests
{
  [TestClass]
  public class FindNotesByCreationTimeCommandTests
  {
    NoteBookProvider provider = new NoteBookProvider();
    NoteProvider noteProvider = new NoteProvider();

    [TestMethod]
    public void TestFindNotesByCreationTime()
    {
      provider.CreateNoteBook();  
      Note note = noteProvider.GetNote();
      provider.NoteBook.AddNote(note);
    
      FindNotesByCreationTimeCommand command = new FindNotesByCreationTimeCommand(provider);
      List<Note> notes = new List<Note>();
      notes.Add(note);
      Assert.AreEqual(notes, command.FindNotesByCreationTime(note.CreationTime));
    }
  }
}
