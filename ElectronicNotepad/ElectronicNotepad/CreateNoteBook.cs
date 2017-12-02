namespace ElectronicNotepad
{
  /// <summary>
  /// This is class for CreateNoteBook command.
  /// </summary>
  public class CreateNoteBook : ICommand
  {
    private NoteBookProvider Receiver { get; set; }
    private string NoteBookName { get; set; }

    /// <summary>
    /// This is constructor for CreateNoteBook with one parameter.
    /// </summary>
    /// <param name="receiver"> Provider </param>
    /// <param name="noteBookName"> Inputted noteBookName </param>
    public CreateNoteBook(NoteBookProvider receiver, string noteBookName)
    {
      Receiver = receiver;
      NoteBookName = noteBookName;
    }

    /// <summary>
    /// This method calls needed method.
    /// </summary>
    public void Execute()
    {
      Receiver.CreateNoteBook(NoteBookName);
    }
  }
}