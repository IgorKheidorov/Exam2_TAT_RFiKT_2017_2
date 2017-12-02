using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElectronicNotepad.Tests
{
  [TestClass]
  public class NoteBookProviderPositiveTests
  {
    [TestMethod]
    public void CreateNoteBook_name_successfulCreate()
    {
      Assert.IsNotNull(new NoteBookProvider().CreateNoteBook("name"));
    }

    [TestMethod]
    public void AddNote_note_succesfaulAdd()
    {
      NoteBookProvider noteBookProvider = new NoteBookProvider();
      noteBookProvider.CreateNoteBook("name");
      Note note = new Note();
      noteBookProvider.AddNote(note);
      Assert.AreEqual(noteBookProvider.NotePad.Content[0], note);
    }

    [TestMethod]
    public void SearchNoteByContext_trueText_equalValues()
    {
      NoteBookProvider noteBookProvider = new NoteBookProvider();
      noteBookProvider.CreateNoteBook("name");
      Note note = new Note("name", "content");
      noteBookProvider.AddNote(note);
      Assert.AreEqual(true, note.Content.Equals("content"));
    }

    [TestMethod]
    public void SearchNoteByDate_trueDate_trueValue()
    {
      NoteBookProvider noteBookProvider = new NoteBookProvider();
      noteBookProvider.CreateNoteBook("name");
      Note note = new Note("name", "content");
      noteBookProvider.AddNote(note);
      Assert.AreEqual(true, note.CreationTime.Equals(note.CreationTime));
    }
  }
}
