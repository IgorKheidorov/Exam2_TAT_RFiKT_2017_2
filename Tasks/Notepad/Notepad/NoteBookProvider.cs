using Notepad.Commands;

namespace Notepad
{
  /// <summary>
  /// Class contains notebook
  /// over which he executes commands
  /// </summary>
  public class NoteBookProvider
  {
    public NoteBook NoteBook { get; set; }
    public Command Command { get; set; }

    /// <summary>
    /// Set current notebook
    /// </summary>
    /// <param name="noteBook"></param>
    public NoteBookProvider(NoteBook noteBook)
    {
      NoteBook = noteBook;
    }

    /// <summary>
    /// Execute current command
    /// </summary>
    public void RunCommand()
    {
      Command.Execute();
    }
  }
}
