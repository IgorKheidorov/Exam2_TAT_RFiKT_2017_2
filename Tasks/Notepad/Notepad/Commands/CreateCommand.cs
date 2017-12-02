using System.Text.RegularExpressions;
using Notepad.CommandExceptions;

namespace Notepad.Commands
{
  /// <summary>
  /// Command Create new NoteBook
  /// </summary>
  public class CreateCommand: Command
  {
    private static string name = "create notebook";
    private readonly Regex regex = new Regex(@"create notebook (\w+)");

    /// <summary>
    /// Set args of command from paramether args
    /// Throws if want be create this command with invalid args
    /// </summary>
    /// <param name="provider"></param>
    /// <param name="args"></param>
    public CreateCommand(NoteBookProvider provider, string args)
    {
      if (!args.StartsWith(name))
      {
        throw new CommandTypeException();
      }
      Name = name;
      Args = regex.Match(args).Value;
      NoteBookProvider = provider;
    }

    /// <summary>
    /// Create new notebook with name from field args
    /// </summary>
    public override void Execute()
    {
      NoteBookProvider.NoteBook = new NoteBook(Args);
    }
  }
}
