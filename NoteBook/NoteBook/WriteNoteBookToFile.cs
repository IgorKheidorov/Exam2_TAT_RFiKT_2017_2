using System;

namespace NoteBook
{
  /// <summary>
  /// This class write notebook to file
  /// </summary>
  public class WriteNoteBookToFile: Command
  {
    String path;
    NoteBookProvider noteBookProvider;

    /// <summary>
    /// this constructor assigns fields
    /// </summary>
    /// <param name="provider">value interested note book provider</param>
    /// <param name="path">path of file in which we write notrbook</param>
    public WriteNoteBookToFile(NoteBookProvider provider, String path)
    {
      noteBookProvider = provider;
      this.path = path;
    }

    /// <summary>
    /// This method of command
    /// </summary>
    public void Execute()
    {
      noteBookProvider.WriteNoteBookToFile(path);
    }
  }
}
