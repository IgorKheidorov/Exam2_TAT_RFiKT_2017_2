
namespace Notebook.CommandImplementation
{
  /// <summary>
  /// This class implements add note function.
  /// </summary>
  class AddNote : Command
  {
    NoteBook noteBook;
    string value;
    string title;
    public AddNote(NoteBook noteBook, string value, string title)
    {
      this.noteBook = noteBook;
      this.value = value;
      this.title = title;
    }
    /// <summary>
    /// Executes AddNote method from NoteBook.
    /// </summary>
    public void Execute()
    {
      noteBook.AddNote(value, title);
    }
  }
}
