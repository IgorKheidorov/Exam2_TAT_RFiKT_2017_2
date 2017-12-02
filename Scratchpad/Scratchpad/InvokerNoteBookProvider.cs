namespace Scratchpad
{
  /// <summary>
  /// For calling the needful command
  /// </summary>
  public class InvokerNoteBookProvider
  {
    Command command;

    /// <summary>
    /// For choosing needful command
    /// </summary>
    /// <param name="command"> Command for choosing</param>
    public void SetCommand(Command command)
    {
      this.command = command;
    }

    /// <summary>
    /// For run the command
    /// </summary>
    public void Run()
    {
      command.Execute();
    }
  }
}
