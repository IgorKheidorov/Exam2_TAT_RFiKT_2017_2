namespace Test4
{
  /// <summary>
  /// This class show notes in notebook.
  /// </summary>
  public class ShowNotesInNotebook : Command
  {
    NoteBook noteBook;

    /// <summary>
    /// This constructor determines field of class.
    /// </summary>
    /// <param name="noteBook">Notebook.</param>
    public ShowNotesInNotebook(NoteBook noteBook)
    {
      this.noteBook = noteBook;
    }

    /// <summary>
    /// Adds method FindNotesInNotebookByDateCreation.
    /// </summary>
    public void Execute()
    {
      noteBook.ShowNotesInNotebook();
    }
  }
}
