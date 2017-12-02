using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Notepad.Tests
{
  [TestFixture]
  public class NoteTests
  {
    private static object[] sourceCreate =
    {
      new object[] {"title", ""},
      new object[] {"", "content"},
      new object[] {"title","content"},
    };

    [Test]
    public void CreateNoteIsNote()
    {
      string title = "title";
      Note note = new Note(title);
      Assert.IsInstanceOf(typeof(Note), note);
    }

    [Test]
    public void CreateNoteValidTitle()
    {
      string title = "title";
      Note note = new Note(title);
      Assert.AreEqual(note.Title,title);
    }

    [Test, TestCaseSource("sourceCreate")]
    public void CreateNoteWithContentValidTitle(string title, string content)
    {
      Note note = new Note(title);
      note.Content = content;
      Assert.AreEqual(note.Title, title);
    }

    [Test, TestCaseSource("sourceCreate")]
    public void CreateNoteWithContentValidContent(string title, string content)
    {
      Note note = new Note(title);
      note.Content = content;
      Assert.AreEqual(note.Title, title);
    }

    [Test, TestCaseSource("sourceCreate")]
    public void CreateNotesWithSameTitlesAndContentAreEqual(string title, string content)
    {
      Note note1 = new Note(title);
      note1.Content = content;
      Note note2 = new Note(title);
      note2.Content = content;
      Assert.AreEqual(note1, note2);
    }

    [Test, TestCaseSource("sourceCreate")]
    public void CreateNotesWithSameTitlesAndContentDatesAreNotEqual(string title, string content)
    {
      Note note1 = new Note(title);
      note1.Content = content;
      Note note2 = new Note(title);
      note2.Content = content;
      Assert.AreNotEqual(note1.Date, note2.Date);
    }
  }
}
