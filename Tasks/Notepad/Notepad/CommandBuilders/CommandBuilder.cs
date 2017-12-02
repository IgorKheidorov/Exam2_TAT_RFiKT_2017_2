using Notepad.Commands;

namespace Notepad.CommandBuilders
{
  /// <summary>
  /// Abstract class Builder
  /// Realizes pattern chain of responsibility
  /// </summary>
  public abstract class CommandBuilder
  {
    protected CommandBuilder successor;
    public abstract Command Build(NoteBookProvider provider, string args);
  }
}
