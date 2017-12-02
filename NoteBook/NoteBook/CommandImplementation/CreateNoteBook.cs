
namespace Notebook.CommandImplementation
{
  /// <summary>
  /// This class implements create note book function.
  /// </summary>
  class CreateNoteBook : Command
  {
    NoteBook noteBook;
    public CreateNoteBook(NoteBook noteBook)
    {
      this.noteBook = noteBook;
    }
    /// <summary>
    /// Executes CreateNoteBook method from NoteBook.
    /// </summary>
    public void Execute()
    {
      noteBook.CreateNoteBook();
    }
  }
}
