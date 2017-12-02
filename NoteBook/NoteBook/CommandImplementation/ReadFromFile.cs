
namespace Notebook.CommandImplementation
{
  /// <summary>
  /// This class implements read from file function.
  /// </summary>
  class ReadFromFile
  {
    NoteBook noteBook;
    string path;
    public ReadFromFile(NoteBook noteBook, string path)
    {
      this.noteBook = noteBook;
      this.path = path;
    }
    /// <summary>
    /// Executes ReadFromFile method from NoteBook.
    /// </summary>
    public void Execute()
    {
      noteBook.ReadFromFile(path);
    }
  }
}
