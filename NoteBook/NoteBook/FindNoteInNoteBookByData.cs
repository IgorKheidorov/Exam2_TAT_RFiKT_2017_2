using System;

namespace NoteBook
{
  /// <summary>
  /// This class of Command FindNoteInNoteBookByData
  /// </summary>
  public class FindNoteInNoteBookByData : Command
  {
    String data;
    NoteBookProvider noteBookProvider;

    /// <summary>
    /// This constructor assign fields
    /// </summary>
    /// <param name="provider">value interested note book provider</param>
    /// <param name="data">data which we want find</param>
    public FindNoteInNoteBookByData(NoteBookProvider provider, String data)
    {
      noteBookProvider = provider;
      this.data = data;
    }

    /// <summary>
    /// override method of command
    /// </summary>
    public void Execute()
    {
      noteBookProvider.FindNoteInNoteBookByData(data);
    }
  }
}
