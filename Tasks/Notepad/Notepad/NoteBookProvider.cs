
using Notepad.Commands;

namespace Notepad
{
  /// <summary>
  /// 
  /// </summary>
  public class NoteBookProvider
  {
    public NoteBook NoteBook { get; set; }
    public ICommand Command { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="noteBook"></param>
    public NoteBookProvider(NoteBook noteBook)
    {
      NoteBook = noteBook;
    }

    /// <summary>
    /// 
    /// </summary>
    public void RunCommand()
    {
      Command.Execute();
    }
  }
}
