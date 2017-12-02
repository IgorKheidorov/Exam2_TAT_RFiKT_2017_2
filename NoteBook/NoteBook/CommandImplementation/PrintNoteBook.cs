
namespace Notebook.CommandImplementation
{
  /// <summary>
  /// This class implements print all note function.
  /// </summary>
  public class PrintNoteBook : Command
  {
    NoteBookConsoleViewer viewer;

    public PrintNoteBook(NoteBook noteBook)
    {
      viewer = new NoteBookConsoleViewer(noteBook);
    }
    /// <summary>
    /// Executes Print function from NoteBookConsoleViewer.
    /// </summary>
    public void Execute()
    {
      viewer.Print();
    }

  }
}
