namespace Test4
{
  /// <summary>
  /// This class find notes in notebook by date of creation.
  /// </summary>
  public class FindNotesInNotebookByDateCreation : Command
  {
    NoteBook noteBook;

    /// <summary>
    /// This constructor determines field of class.
    /// </summary>
    /// <param name="noteBook">Notebook.</param>
    public FindNotesInNotebookByDateCreation(NoteBook noteBook)
    {
      this.noteBook = noteBook;
    }

    /// <summary>
    /// Adds method FindNotesInNotebookByDateCreation.
    /// </summary>
    public void Execute()
    {
      noteBook.FindNotesInNotebookByDateCreation();
    }
  }
}
