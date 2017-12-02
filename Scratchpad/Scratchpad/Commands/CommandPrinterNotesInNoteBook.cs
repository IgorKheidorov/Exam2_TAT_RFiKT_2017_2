namespace Scratchpad
{
  /// <summary>
  /// For show notes in the noteBook
  /// </summary>
  public class CommandShowNotesInNoteBook : Command
  {
    NoteBookConsoleViewer noteBook;

    /// <summary>
    /// Trivial constructor
    /// </summary>
    /// <param name="noteBook"> note book for showing</param>
    public CommandShowNotesInNoteBook(NoteBookConsoleViewer noteBook)
    {
      this.noteBook = noteBook;
    }

    /// <summary>
    /// For calling the print method
    /// </summary>
    public override void Execute()
    {
      noteBook.PrintNoteBook();
    }
  }
}
