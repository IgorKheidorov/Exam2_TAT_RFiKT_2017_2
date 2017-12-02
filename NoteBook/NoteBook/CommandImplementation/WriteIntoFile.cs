
namespace Notebook.CommandImplementation
{
  /// <summary>
  /// This class implements write into file function.
  /// </summary>
  class WriteIntoFile
  {
    NoteBook noteBook;
    string path;
    public WriteIntoFile(NoteBook noteBook,string path)
    {
      this.noteBook = noteBook;
      this.path = path;
    }
    /// <summary>
    /// Executes WriteIntoFile method from NoteBook.
    /// </summary>
    public void Execute()
    {
      noteBook.WriteIntoFile(path);
    }
  }
}
