namespace Scratchpad
{
  /// <summary>
  /// Fo addition the new note
  /// </summary>
  public class CommandAddNewNoteToNoteBook : Command
  {
    NoteBook noteBook;
    string record;

    /// <summary>
    /// The trivial constructor
    /// </summary>
    /// <param name="noteBook"> The noteBook for addition</param>
    /// <param name="record">The value which you wanted to add</param>
    public CommandAddNewNoteToNoteBook(NoteBook noteBook, string record)
    {
      this.noteBook = noteBook;
      this.record = record;
    }

    /// <summary>
    /// Call command: for addtion.
    /// </summary>
    public override void Execute()
    {
      noteBook.AddNewNote(record);
    }
  }
}
