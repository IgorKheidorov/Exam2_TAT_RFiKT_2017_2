using System.Collections.Generic;

namespace NoteBook
{
  /// <summary>
  /// This program create notebook and give ability to work with data like with notebook.
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    /// Code of program which use buissness logic
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      NoteBookProvider noteBookProvider = new NoteBookProvider();
      Invoker invoker = new Invoker();
      List<Command> commands = new List<Command>();
      commands.Add(new CreateObject(noteBookProvider));
      commands.Add(new AddNote(noteBookProvider, new Note("Today", "go to the the meeting")));
      commands.Add(new ShowNotesOfNotebook(noteBookProvider));
      commands.Add(new FindNoteInNoteBookByData(noteBookProvider, "go to the the meeting"));
      commands.Add(new FindNoteInNoteBookByDate(noteBookProvider, "02.12.2017 19:13:53"));
      commands.Add(new WriteNoteBookToFile(noteBookProvider, @"C:\Users\nikit\Desktop\NoteBook\NoteBook\NoteBook.txt"));
      foreach (var command in commands)
      {
        invoker.SetCommand(command);
        invoker.ExecuteCommand();
      }
    }
  }
}
