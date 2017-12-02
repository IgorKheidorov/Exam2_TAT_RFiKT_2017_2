namespace NoteBook
{
  /// <summary>
  /// This class show notes of notebook
  /// </summary>
  public class ShowNotesOfNotebook: Command
  {
    NoteBookProvider noteBookProvider;

    /// <summary>
    /// This constructor assign fields
    /// </summary>
    /// <param name="provider">value interested note book provider</param>
    public ShowNotesOfNotebook(NoteBookProvider provider)
    {
      noteBookProvider = provider;
    }

    /// <summary>
    /// This method of command
    /// </summary>
    public void Execute()
    {
      noteBookProvider.ShowNotesOfNotebook(noteBookProvider);
    }
  }
}
