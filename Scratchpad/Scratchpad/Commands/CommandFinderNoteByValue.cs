namespace Scratchpad
{
  /// <summary>
  ///  If you want to find the note by value this class will help you
  /// </summary>
  public class CommandFindNoteByValue : Command
  {
    NoteBook noteBook;
    string data;

    /// <summary>
    /// The trivial constructor
    /// </summary>
    /// <param name="noteBook"> The noteBook for searching</param>
    /// <param name="record">The value by which you want to search </param>
    public CommandFindNoteByValue(NoteBook noteBook, string data)
    {
      this.noteBook = noteBook;
      this.data = data;
    }

    /// <summary>
    /// For calling search method
    /// </summary>
    public override void Execute()
    {
      noteBook.FindNoteByValue(data);
    }
  }
}
