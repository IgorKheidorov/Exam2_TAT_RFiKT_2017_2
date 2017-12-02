namespace NoteBook
{
  /// <summary>
  /// This class of Command CreateObject
  /// </summary>
  public class CreateObject : Command
  {
    NoteBookProvider noteBookProvider;

    /// <summary>
    /// this constructor assign fields
    /// </summary>
    /// <param name="provider">value interested note book provider</param>
    public CreateObject(NoteBookProvider provider)
    {
      noteBookProvider = provider;
    }

    /// <summary>
    /// override method of command
    /// </summary>
    public void Execute()
    {
      noteBookProvider = noteBookProvider.CreatObject();
    }
  }
}
