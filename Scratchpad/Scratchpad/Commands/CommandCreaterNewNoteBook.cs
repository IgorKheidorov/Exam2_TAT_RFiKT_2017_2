namespace Scratchpad
{
  /// <summary>
  /// For creating new note in the noteBook
  /// </summary>
  public class CommandCreateNewNoteBook : Command
  {
    NoteBook noteBook;
    string data;

    /// <summary>
    /// The trivial constructor
    /// </summary>
    /// <param name="noteBook"> The noteBook for creating</param>
    /// <param name="record">The value which you wanted to add </param>
    public CommandCreateNewNoteBook(NoteBook noteBook, string data)
    {
      this.noteBook = noteBook;
      this.data = data;
    }

    /// <summary>
    /// Call command for creating
    /// </summary>
    public override void Execute()
    {
      noteBook.CreateNewNoteBook(data);
    }
  }
}
