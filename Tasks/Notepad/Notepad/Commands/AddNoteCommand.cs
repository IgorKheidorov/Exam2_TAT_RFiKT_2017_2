using System.Text.RegularExpressions;
using Notepad.CommandExceptions;

namespace Notepad.Commands
{
  /// <summary>
  /// 
  /// </summary>
  public class AddNoteCommand : ICommand
  {
    private string name = "add note";
    private NoteBookProvider currentNoteBookProvider;
    private string args;
    private Regex regex = new Regex(@"add note {\w+}");

    /// <summary>
    /// Set args of command from paramether args
    /// Throws if want be create this command with invalid args
    /// </summary>
    /// <param name="provider"></param>
    /// <param name="args"></param>
    public AddNoteCommand(NoteBookProvider provider, string args)
    {
      if (!args.StartsWith(name))
      {
        throw new CommandTypeException();
      }
      this.args = regex.Match(args).Value;
      currentNoteBookProvider = provider;
    }

    /// <summary>
    /// Set providers notebook new notebook with name in field args
    /// </summary>
    public void Execute()
    {
      currentNoteBookProvider.NoteBook = new NoteBook(args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public string Name()
    {
      return name;
    }
  }
}
