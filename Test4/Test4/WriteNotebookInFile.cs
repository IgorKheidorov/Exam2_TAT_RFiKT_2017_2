namespace Test4
{
  /// <summary>
  /// This class writes notebook in file.
  /// </summary>
  public class WriteNotebookInFile : Command
  {
    NoteBook noteBook;

    /// <summary>
    /// This constructor determines field of class.
    /// </summary>
    /// <param name="noteBook">Notebook.</param>
    public WriteNotebookInFile(NoteBook noteBook)
    {
      this.noteBook = noteBook;
    }

    /// <summary>
    /// Adds method WriteNotebookInFile.
    /// </summary>
    public void Execute()
    {
      noteBook.WriteNotebookInFile();
    }
  }
}
