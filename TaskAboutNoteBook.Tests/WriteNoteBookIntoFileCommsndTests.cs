using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskAboutNoteBook.Tests
{
  [TestClass]
  public class WriteNoteBookIntoFileCommsndTests
  {
    NoteBookProvider noteBookProvider = new NoteBookProvider();

    [TestMethod]
    public void TestWriteNoteBookIntoFile()
    {
      WriteNoteBookIntoFileCommand command = new WriteNoteBookIntoFileCommand(noteBookProvider);
      Assert.IsTrue(command.WriteNoteBookIntoFile("../../file.txt"));
    }
  }
}
