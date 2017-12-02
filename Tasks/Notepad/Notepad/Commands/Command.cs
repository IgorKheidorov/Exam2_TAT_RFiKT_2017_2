
namespace Notepad.Commands
{
  /// <summary>
  /// Absract class Command
  /// with Name, Args
  /// and current Notebook provider
  /// </summary>
  public abstract class Command
  {
    public NoteBookProvider NoteBookProvider { get; protected set; }
    public string Name { get; protected set; }
    public string Args { get; protected set; }

    public abstract void Execute();
  }
}
