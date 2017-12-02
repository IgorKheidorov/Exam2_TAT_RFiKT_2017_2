using System;

namespace ElectronicNoteBook
{
  /// <summary>
  /// This class is used to call commands
  /// </summary>
  class ConcreteCommand : Command
  {
    Receiver receiver;
    object[] parametrs;

    public ConcreteCommand(params object[] parametrs)
    {
      this.parametrs = parametrs;
      receiver = new Receiver();
    }

    /// <summary>
    /// Calls commands
    /// </summary>
    public override void Execute()
    {
      receiver.SwitchOperation(parametrs);
    }
  }
}
