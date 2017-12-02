namespace Test4
{
  /// <summary>
  /// This class adds note in notebook.
  /// </summary>
  public class AddNoteInNoteBook : Command
  {
    NoteBook noteBook;

    /// <summary>
    /// This constructor determines field of class.
    /// </summary>
    /// <param name="noteBook">Notebook.</param>
    public AddNoteInNoteBook(NoteBook noteBook)
    {
      this.noteBook = noteBook;
    }

    /// <summary>
    /// Adds method AddNoteInNoteBook.
    /// </summary>
    public void Execute()
    {
      noteBook.AddNoteInNoteBook();
    }
  }
}
