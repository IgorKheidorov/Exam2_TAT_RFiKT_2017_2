using System.Text.RegularExpressions;
using Notepad.CommandExceptions;

namespace Notepad.Commands
{
  /// <summary>
  /// Command Add Note in NoteBook
  /// </summary>
  public class AddNoteCommand : Command
  {
    private static string name = "add note";
    private readonly Regex regex = new Regex(@"add note (\w+)");

    /// <summary>
    /// Set args of command from paramether args
    /// Throws if want be create this command with invalid args
    /// </summary>
    /// <param name="provider"></param>
    /// <param name="args"></param>
    public AddNoteCommand(NoteBookProvider provider, string args) : base(provider)
    {
      if (!args.StartsWith(name))
      {
        throw new CommandTypeException();
      }
      Name = name;
      Args = regex.Match(args).Value;
    }

    /// <summary>
    /// Add in providers notebook new note with title from field args
    /// </summary>
    public override void Execute()
    {
      NoteBookProvider.NoteBook.Notes.Add(new Note(Args));
    }

  }
}
