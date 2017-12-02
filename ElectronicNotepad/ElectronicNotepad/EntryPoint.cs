using System;
using System.Collections.Generic;

namespace ElectronicNotepad
{
  /// <summary>
  /// This is entry point to program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        List<Note> noteList = new List<Note>();
        Invoker invoker = new Invoker();
        NoteBookProvider provider = new NoteBookProvider();
        string noteBookName = Console.ReadLine();
        List<ICommand> commands = new List<ICommand>
      {
        new CreateNoteBook(provider, noteBookName),
        new AddNote(provider, new Note("note", "This is note.")),
        new DisplayNoteBook(provider)
      };
        foreach (var command in commands)
        {
          invoker.SetCommand(command);
          invoker.Run();
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}