using System;

namespace ElectronicNoteBook
{
  /// <summary>
  /// This class is used to call commands
  /// </summary>
  public class ConcreteCommand : Command
  {
    Receiver receiver;
    object[] parametrs;

    public ConcreteCommand(params object[] parametrs)
    {
      this.parametrs = new object[parametrs.Length];
      Array.Copy(parametrs, this.parametrs, parametrs.Length);
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
