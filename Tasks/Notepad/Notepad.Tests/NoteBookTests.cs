using NUnit.Framework;

namespace Notepad.Tests
{
  [TestFixture]
  public class NoteBookTests
  {
    private static object[] sourceNote =
    {
      new object[] {"title", ""},
      new object[] {"", "content"},
      new object[] {"title","content"},
    };

    private static object[] sourceNoteBooksCountIds =
    {
      new object[] {1,0},
      new object[] {2,1},
      new object[] {5,4},
    };

    [Test]
    public void CreateNoteBookIsNoteBook()
    {
      string name = "name";
      NoteBook noteBook = new NoteBook(name);
      Assert.IsInstanceOf(typeof(NoteBook), noteBook);
    }

    [Test]
    public void CreateNoteBookValidName()
    {
      string name = "name";
      NoteBook noteBook = new NoteBook(name);
      Assert.AreEqual(noteBook.Name, name);
    }

    [Test, TestCaseSource("sourceNoteBooksCountIds")]
    public void CreateNoteBooksValidId(int count, int lastId)
    {
      string name = "name";
      NoteBook[] noteBooks = new NoteBook[count];
      for (int i = 0; i < count; i++)
      {
        noteBooks[i] = new NoteBook(name);
      }
      Assert.AreEqual(noteBooks[count-1].Id, lastId);
    }

    [Test, TestCaseSource("sourceNotes")]
    public void AddInNoteBooksSameNotesAreEqual(string noteTitle, string noteContent)
    {
      string name = "name";
      NoteBook noteBook1 = new NoteBook(name);
      NoteBook noteBook2 = new NoteBook(name);
      Note note = new Note(noteTitle);
      note.Content = noteContent;
      noteBook1.Notes.Add(note);
      noteBook2.Notes.Add(note);

      Assert.AreEqual(noteBook1, noteBook2);
    }
  }
}
