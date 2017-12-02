using System;

namespace NoteBook
{
  /// <summary>
  /// This class of command find note in notebook by time
  /// </summary>
  public class FindNoteInNoteBookByDate : Command
  {
    String time;
    NoteBookProvider noteBookProvider;

    /// <summary>
    ///  This constructor assign fields
    /// </summary>
    /// <param name="provider">value interested note book provider</param>
    /// <param name="time">time with which we want find note</param>
    public FindNoteInNoteBookByDate(NoteBookProvider provider, String time)
    {
      noteBookProvider = provider;
      this.time = time;
    }

    /// <summary>
    /// override method of command
    /// </summary>
    public void Execute()
    {
      noteBookProvider.FindNoteInNoteBookByDate(time);
    }
  }
}
