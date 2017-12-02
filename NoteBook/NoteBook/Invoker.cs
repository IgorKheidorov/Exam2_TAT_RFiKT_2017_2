namespace NoteBook
{ 
  /// <summary>
  /// This class for invok command in main
  /// </summary>
  public class Invoker
  {
    private Command command;

    /// <summary>
    /// this method choose command for execution
    /// </summary>
    /// <param name="command"></param>
    public void SetCommand(Command command)
    {
      this.command = command;
    }

    /// <summary>
    /// this mehod execute choosen command
    /// </summary>
    public void ExecuteCommand()
    {
      command.Execute();
    }
  }
}
