using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskAboutNoteBook.Tests
{
  [TestClass]
  public class NoteBookTests
  {
    NoteBookProvider provider = new NoteBookProvider();   
    NoteProvider noteProvider = new NoteProvider();

    [TestMethod]
    public void TestAddNoteCommandExecute()
    {
      provider.CreateNoteBook();
      provider.NoteBook.AddNote(noteProvider.GetNote());
      NoteBookConsoleView noteBookConsoleView = new NoteBookConsoleView(provider);   
      Assert.AreEqual(noteProvider.GetNote().ToString(), noteBookConsoleView.Print());

    }
  }
}
