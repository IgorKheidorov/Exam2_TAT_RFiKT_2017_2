using System.Text.RegularExpressions;
using Notepad.CommandExceptions;

namespace Notepad.Commands
{
  /// <summary>
  /// Command Search notes by date in NoteBook
  /// </summary>
  public class SearchByDateCommand : Command
  {
    private static string name = "search date";
    private readonly Regex regex = new Regex(@"search date (\d{1,2}\.\d{1,2}\.\d{4})");

    /// <summary>
    /// Set args of command from paramether args
    /// Throws if want be create this command with invalid args
    /// </summary>
    /// <param name="provider">current provider</param>
    /// <param name="args">commands args</param>
    public SearchByDateCommand(NoteBookProvider provider, string args) : base(provider)
    {
      if (!args.StartsWith(name))
      {
        throw new CommandTypeException();
      }
      Name = name;
      Args = regex.Match(args).Value;
    }

    /// <summary>
    /// Search notes by date from args in current notebook
    /// </summary>
    public override void Execute()
    {
      // TO DO
    }
  }
}

