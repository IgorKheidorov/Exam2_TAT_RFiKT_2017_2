namespace Test4
{
  /// <summary>
  /// This class finds notes in notebook by content.
  /// </summary>
  public class FindNotesInNotebookByContent : Command
  {
    private NoteBook noteBook;

    /// <summary>
    /// This constructor determines field of class.
    /// </summary>
    /// <param name="noteBook">Notebook.</param>
    public FindNotesInNotebookByContent(NoteBook noteBook)
    {
      this.noteBook = noteBook;
    }

    /// <summary>
    /// Adds method FindNotesInNotebookByContent.
    /// </summary>
    public void Execute()
    {
      noteBook.FindNotesInNotebookByContent();
    }
  }
}
