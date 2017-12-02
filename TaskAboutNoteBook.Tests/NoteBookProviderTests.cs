using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskAboutNoteBook.Tests
{
  [TestClass]
  public class NoteBookProviderTests
  {
    NoteBookProvider provider = new NoteBookProvider();

    [TestMethod]
    public void TestLoadNoteBookFromFile()
    {
      Assert.IsTrue(provider.LoadNoteBookFromFile("../../file.txt"));
    }

    [TestMethod]
    public void TestCreateNoteBook()
    {
      provider.CreateNoteBook();
      Assert.IsTrue(provider.NoteBook != null);
    }
  }
}
