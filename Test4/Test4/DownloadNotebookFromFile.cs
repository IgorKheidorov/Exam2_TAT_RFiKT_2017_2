namespace Test4
{
  /// <summary>
  /// This class downloads notebook from file.
  /// </summary>
  public class DownloadNotebookFromFile : Command
  {
    NoteBook noteBook;

    /// <summary>
    /// This constructor determines field of class.
    /// </summary>
    /// <param name="noteBook">Notebook.</param>
    public DownloadNotebookFromFile(NoteBook noteBook)
    {
      this.noteBook = noteBook;
    }

    /// <summary>
    /// Adds method DownloadNotebookFromFile.
    /// </summary>
    public void Execute()
    {
      noteBook.DownloadNotebookFromFile();
    }
  }
}
