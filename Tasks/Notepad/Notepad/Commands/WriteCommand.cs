using System.Text.RegularExpressions;
using Notepad.CommandExceptions;

namespace Notepad.Commands
{
  /// <summary>
  /// Command Write NoteBook
  /// </summary>
  public class WriteCommand : Command
  {
    private static string name = "write";
    private readonly Regex regex = new Regex(@"read (\w+\.\w{1,3})");

    /// <summary>
    /// Set args of command from paramether args
    /// Throws if want be create this command with invalid args
    /// </summary>
    /// <param name="provider">current provider</param>
    /// <param name="args">commands args</param>
    public WriteCommand(NoteBookProvider provider, string args) : base(provider)
    {
      if (!args.StartsWith(name))
      {
        throw new CommandTypeException();
      }
      Name = name;
      Args = regex.Match(args).Value;
    }

    /// <summary>
    /// Write notebook in file in field args
    /// </summary>
    public override void Execute()
    {
      // TO DO
    }
  }
}
