using System.Text.RegularExpressions;
using Notepad.CommandExceptions;

namespace Notepad.Commands
{
  /// <summary>
  /// Command View notes in NoteBook
  /// </summary>
  public class ViewNotesCommand : Command
  {
    private static string name = "view";
    private readonly Regex regex = new Regex(@"view (\d+)");

    /// <summary>
    /// Set args of command from paramether args
    /// Throws if want be create this command with invalid args
    /// </summary>
    /// <param name="provider">current provider</param>
    /// <param name="args">commands args</param>
    public ViewNotesCommand(NoteBookProvider provider, string args) : base(provider)
    {
      if (!args.StartsWith(name))
      {
        throw new CommandTypeException();
      }
      Name = name;
      Args = regex.Match(args).Value;
    }

    /// <summary>
    /// View notes in current notebook.
    /// Count of viewed notes is in args
    /// </summary>
    public override void Execute()
    {
      // TO DO
    }
  }
}

