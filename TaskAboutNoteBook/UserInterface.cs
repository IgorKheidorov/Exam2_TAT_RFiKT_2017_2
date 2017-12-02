using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAboutNoteBook
{
  /// <summary>
  /// Representation of userinterface.
  /// </summary>
  class UserInterface
  {
    private Dictionary<string, Command> commands;
    private NoteBookProvider noteBookProvider;
    private NoteBookConsoleView noteBookConsoleView;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="noteBookProvider">Instance of NoteBookProvider</param>
    /// <param name="noteBookConsoleView">Instance of NoteBookConsoleView.</param>
    public UserInterface(NoteBookProvider noteBookProvider, NoteBookConsoleView noteBookConsoleView)
    {
      this.noteBookProvider = noteBookProvider;
      this.noteBookConsoleView = noteBookConsoleView;
      commands = new Dictionary<string, Command>();
    }

    /// <summary>
    /// Runs userinterface.
    /// </summary>
    public void Run()
    {
      StringBuilder menu = new StringBuilder();
      menu.AppendLine("Please select a command :");
      menu.AppendLine("1. Create new NoteBook.");
      menu.AppendLine("2. Add note to NoteBook.");
      menu.AppendLine("3. Find notes by data.");
      menu.AppendLine("4. Find notes by creation time.");
      menu.AppendLine("5. Show notes.");
      menu.AppendLine("6. Write NoteBook in file.");
      menu.AppendLine("7. Load NoteBook from file.");
      Console.WriteLine(menu.ToString());
      string key = Console.ReadLine();
      if (commands.ContainsKey(key))
      {
        commands[key].Execute();
      }
    }

    private void BuildDictionary()
    {     
      commands.Add("1", new CreateNoteBookCommand(noteBookProvider));
      commands.Add("2", new AddNoteCommand(noteBookProvider.NoteBook));
      commands.Add("3", new FindNotesByDataCommand(noteBookProvider));
      commands.Add("4", new FindNotesByCreationTimeCommand(noteBookProvider));
      commands.Add("5", new ShowNotesCommand(noteBookConsoleView));
      commands.Add("6", new WriteNoteBookIntoFileCommand(noteBookProvider));
      commands.Add("7", new LoadNoteBookFromFileCommand(noteBookProvider));
    }
  }
}
