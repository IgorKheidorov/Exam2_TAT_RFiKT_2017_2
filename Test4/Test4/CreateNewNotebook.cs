namespace Test4
{
  /// <summary>
  /// This class creates new notebook.
  /// </summary>
  public class CreateNewNotebook : Command
  {
    private NoteBook noteBook;

    /// <summary>
    /// This constructor determines field of class.
    /// </summary>
    /// <param name="noteBook">Notebook.</param>
    public CreateNewNotebook(NoteBook noteBook)
    {
      this.noteBook = noteBook;
    }

    /// <summary>
    /// Adds method CreateNewNoteBook.
    /// </summary>
    public void Execute()
    {
      noteBook.CreateNewNoteBook();
    }
  }
}
