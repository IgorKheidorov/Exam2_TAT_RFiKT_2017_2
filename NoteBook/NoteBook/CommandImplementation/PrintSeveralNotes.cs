
namespace Notebook.CommandImplementation
{
  /// <summary>
  /// This class implements print several notes function.
  /// </summary>
  public class PrintSeveralNotes : Command
  {
    NoteBookConsoleViewer viewer;
    int amount;
    public PrintSeveralNotes(NoteBook noteBook, int amount)
    {
      viewer = new NoteBookConsoleViewer(noteBook);
      this.amount = amount;
    }
    /// <summary>
    /// Executes Print function from NoteBookConsoleViewer.
    /// </summary>
    public void Execute()
    {
      viewer.Print(amount);
    }
  }
}
