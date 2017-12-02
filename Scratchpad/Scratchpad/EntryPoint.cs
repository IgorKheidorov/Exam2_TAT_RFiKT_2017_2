using System;

namespace Scratchpad
{
  /// <summary>
  /// For calling methods
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    /// The entry Point of the programm
    /// </summary>
    static void Main()
    {
      try
      {
        NoteBook notebook = new NoteBook();
        InvokerNoteBookProvider invoker = new InvokerNoteBookProvider();

        invoker.SetCommand(new CommandCreateNewNoteBook(notebook, "123"));
        invoker.Run();

        invoker.SetCommand(new CommandAddNewNoteToNoteBook(notebook, "456"));
        invoker.Run();

        NoteBookConsoleViewer reader = new NoteBookConsoleViewer(notebook);
        invoker.SetCommand(new CommandShowNotesInNoteBook(reader));
        invoker.Run();
      }
      catch(Exception ex)
      {
        Console.Write(ex.Message);
      }
    }
  }
}
