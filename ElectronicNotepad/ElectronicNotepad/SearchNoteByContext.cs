namespace ElectronicNotepad
{
  /// <summary>
  /// This is class for SearchNoteByContext command.
  /// </summary>
  public class SearchNoteByContext : ICommand
  {
    private NoteBookProvider Receiver { get; set; }
    private string Text { get; set; }

    /// <summary>
    /// This is constructor for SearchNoteByContext with one parameter.
    /// </summary>
    /// <param name="receiver"> Provider </param>
    /// <param name="text"> Inputted text </param>
    public SearchNoteByContext(NoteBookProvider receiver, string text)
    {
      Receiver = receiver;
      Text = text;
    }

    /// <summary>
    /// This method calls needed method.
    /// </summary>
    public void Execute()
    {
      Receiver.SearchNoteByContext(Text);
    }
  }
}