using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElectronicNotepad.Tests
{
  [TestClass]
  public class NoteBookProviderTests
  {
    [TestMethod]
    public void SearchNoteByContext_falseText_notEqualValues()
    {
      NoteBookProvider noteBookProvider = new NoteBookProvider();
      noteBookProvider.CreateNoteBook("name");
      Note note = new Note("name", "content");
      noteBookProvider.AddNote(note);
      Assert.AreEqual(false, note.Content.Equals(""));
    }
  }
}