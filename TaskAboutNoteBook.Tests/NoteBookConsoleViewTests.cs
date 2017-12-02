using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskAboutNoteBook.Tests
{
  [TestClass]
  public class NoteBookConsoleViewTests
  {
    NoteBookProvider provider = new NoteBookProvider();
    NoteProvider noteProvider = new NoteProvider();

    [TestMethod]
    public void TestPrintWithoutArguments()
    {
      NoteBookConsoleView consoleView = new NoteBookConsoleView(provider);
      provider.CreateNoteBook();
      provider.NoteBook.AddNote(noteProvider.GetNote());
      Assert.AreEqual(noteProvider.GetNote().ToString(),consoleView.Print());
    }
  }
}
