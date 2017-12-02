namespace NoteBook
{
  /// <summary>
  /// This class of Command AddNote
  /// </summary>
  public class AddNote: Command
  {
    NoteBookProvider noteBookProvider;
    Note note;

    /// <summary>
    /// this constructor assign fields
    /// </summary>
    /// <param name="provider">value with note book provider</param>
    /// <param name="note">value with note which we want add </param>
    public AddNote(NoteBookProvider provider, Note note)
    {
      noteBookProvider = provider;
      this.note = note;
    }

    /// <summary>
    /// override method of command
    /// </summary>
    public void Execute()
    {
      noteBookProvider.AddNote(note);
    }
  }
}
