using System.Text.RegularExpressions;
using Notepad.CommandExceptions;

namespace Notepad.Commands
{
  /// <summary>
  /// Command Search Data in Notebook
  /// </summary>
  public class SearchByDataCommand : Command
  {
    private static string name = "search data";
    private readonly Regex regex = new Regex(@"search data (\w+)");

    /// <summary>
    /// Set args of command from paramether args
    /// Throws if want be create this command with invalid args
    /// </summary>
    /// <param name="provider">current provider</param>
    /// <param name="args">commands args</param>
    public SearchByDataCommand(NoteBookProvider provider, string args) : base(provider)
    {
      if (!args.StartsWith(name))
      {
        throw new CommandTypeException();
      }
      Name = name;
      Args = regex.Match(args).Value;
    }

    /// <summary>
    /// Search args in current notebook
    /// </summary>
    public override void Execute()
    {
      // TO DO
    }
  }
}

