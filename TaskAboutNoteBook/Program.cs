namespace TaskAboutNoteBook
{

  /// <summary>
  /// Entry point.
  /// </summary>
  class Program
  {
    static void Main(string[] args)
    {
      NoteBookProvider noteBookProvider = new NoteBookProvider();    
      NoteBookConsoleView noteBookConsoleView = new NoteBookConsoleView(noteBookProvider);

      UserInterface userInterface = new UserInterface(noteBookProvider, noteBookConsoleView);
      userInterface.Run();
    }
  }
}
