using System;

namespace Scratchpad
{
  /// <summary>
  /// If you want to find the note by date this class will help you
  /// </summary>
  public class CommandFindNoteByDate : Command
  {
    NoteBook noteBook;
    DateTime date;

    /// <summary>
    /// The trivial constructor
    /// </summary>
    /// <param name="noteBook"> The noteBook for searching</param>
    /// <param name="record">The value by which you want to search </param>
    public CommandFindNoteByDate(NoteBook noteBook, DateTime date)
    {
      this.noteBook = noteBook;
      this.date = date;
    }

    /// <summary>
    /// For calling search method
    /// </summary>
    public override void Execute()
    {
      noteBook.FindNoteByDate(date);
    }
  }
}
