using Notebook.CommandImplementation;

namespace Notebook
{
  /// <summary>
  /// Point where programm starts.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      Note note = new Note("here's a text", "example");
      NoteBook noteBook = new NoteBook();
      NoteBookProvider provider = new NoteBookProvider();
      provider.SetCommand(new CreateNoteBook(noteBook));
      provider.Run();
      provider.SetCommand(new AddNote(noteBook, "here's a text", "example"));
      provider.Run();
      provider.SetCommand(new AddNote(noteBook, "text2", "example2"));
      provider.Run();
      provider.SetCommand(new AddNote(noteBook, "text3", "example3"));
      provider.Run();
      provider.SetCommand(new PrintNoteBook(noteBook));
      provider.Run();
      provider.SetCommand(new PrintSeveralNotes(noteBook, 2));
      provider.Run();
    }
  }
}
