namespace ElectronicNotepad
{
  /// <summary>
  /// This is class for DisplayNoteBook command.
  /// </summary>
  public class DisplayNoteBook : ICommand
  {
    private NoteBookProvider Receiver { get; set; }

    /// <summary>
    /// This is constructor for DisplayNoteBook with one parameter.
    /// </summary>
    /// <param name="receiver"> Provider </param>
    public DisplayNoteBook(NoteBookProvider receiver)
    {
      Receiver = receiver;
    }

    /// <summary>
    /// This method calls needed method.
    /// </summary>
    public void Execute()
    {
      Receiver.DisplayNoteBook();
    }
  }
}