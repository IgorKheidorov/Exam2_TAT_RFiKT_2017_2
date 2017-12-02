using Notebook.CommandImplementation;

namespace Notebook
{
  class NoteBookProvider
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
