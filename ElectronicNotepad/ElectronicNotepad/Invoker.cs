namespace ElectronicNotepad
{
  /// <summary>
  /// This is invoker for command pattern.
  /// </summary>
  class Invoker
  {
    public ICommand Command { get; private set; }

    /// <summary>
    /// This method sets command.
    /// </summary>
    /// <param name="command"> Command </param>
    public void SetCommand(ICommand command)
    {
      Command = command;
    }

    /// <summary>
    /// This method runs command.
    /// </summary>
    public void Run()
    {
      Command.Execute();
    }
  }
}