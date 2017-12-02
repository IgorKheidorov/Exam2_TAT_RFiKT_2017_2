namespace ElectronicNotepad
{
  /// <summary>
  /// This is class for WriteNoteBookToTheFile command.
  /// </summary>
  public class WriteNoteBookToTheFile : ICommand
  {
    private NoteBookProvider Receiver { get; set; }

    /// <summary>
    /// This is constructor for WriteNoteBookToTheFile with one parameter.
    /// </summary>
    /// <param name="receiver"> Provider </param>
    public WriteNoteBookToTheFile(NoteBookProvider receiver)
    {
      Receiver = receiver;
    }

    /// <summary>
    /// This method calls needed method.
    /// </summary>
    public void Execute()
    {
      Receiver.WriteNoteBookToTheFile();
    }
  }
}