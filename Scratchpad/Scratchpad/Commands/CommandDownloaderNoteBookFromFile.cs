namespace Scratchpad
{
  /// <summary>
  /// For downloads thr noteBook from file.txt
  /// </summary>
  public class CommandDownloadNoteBookFromFile : Command
  {
    NoteBook noteBook;
    string record;

    /// <summary>
    /// The trivial constructor
    /// </summary>
    /// <param name="noteBook"> The noteBook for downloading</param>
    /// <param name="record">The value which you wanted to download </param>
    public CommandDownloadNoteBookFromFile(NoteBook noteBook, string record)
    {
      this.noteBook = noteBook;
      this.record = record;
    }

    /// <summary>
    /// For calling the download method
    /// </summary>
    public override void Execute()
    {
      noteBook.DownloadNoteBookFromFile();
    }
  }
}
