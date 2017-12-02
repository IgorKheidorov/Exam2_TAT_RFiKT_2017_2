namespace ElectronicNotepad
{
  /// <summary>
  /// This is class for AddNote command.
  /// </summary>
  public class AddNote : ICommand
  {
    private NoteBookProvider Receiver { get; set; }
    private Note NeededNote { get; set; }

    /// <summary>
    /// This is constructor for AddNote with one parameter.
    /// </summary>
    /// <param name="receiver"> Provider </param>
    /// <param name="note"> Needed note </param>
    public AddNote(NoteBookProvider receiver, Note note)
    {
      Receiver = receiver;
      NeededNote = note;
    }

    /// <summary>
    /// This method calls needed method.
    /// </summary>
    public void Execute()
    {
      Receiver.AddNote(NeededNote);
    }
  }
}