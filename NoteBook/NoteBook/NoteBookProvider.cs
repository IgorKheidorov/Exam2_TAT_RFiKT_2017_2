using Notebook.CommandImplementation;

namespace Notebook
{
  /// <summary>
  /// The substance to work with note book, also needed to implement command pattern.
  /// </summary>
  public class NoteBookProvider
  {
    Command command;
    public void SetCommand(Command command)
    {
      this.command = command;
    }
    public void Run()
    {
      command.Execute();
    }
  }
}
