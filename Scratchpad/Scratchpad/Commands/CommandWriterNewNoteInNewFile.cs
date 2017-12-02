namespace Scratchpad
{
  /// <summary>
  /// For writing new note in new .txt file
  /// </summary>
  public class CommandWriteNewNoteInNewFile : Command
  {
    NoteBook noteBook;
    string data;

    /// <summary>
    /// Trivial constructor
    /// </summary>
    /// <param name="noteBook">NoteBook for writing</param>
    public CommandWriteNewNoteInNewFile(NoteBook noteBook, string data)
    {
      this.noteBook = noteBook;
      this.data = data;
    }

    /// <summary>
    /// For calling the method for writing 
    /// </summary>
    public override void Execute()
    {
      noteBook.WriteNewNoteInNewFile();
    }
  }
}
