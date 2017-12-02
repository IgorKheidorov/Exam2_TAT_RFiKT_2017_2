using System;

namespace ElectronicNotepad
{
  /// <summary>
  /// This is class for SearchNoteByDate command.
  /// </summary>
  public class SearchNoteByDate : ICommand
  {
    private NoteBookProvider Receiver { get; set; }
    private DateTime CreationTime { get; set; }

    /// <summary>
    /// This is constructor for SearchNoteByContext with one parameter.
    /// </summary>
    /// <param name="receiver"> Provider </param>
    /// <param name="dateTime"> Inputted date </param>
    public SearchNoteByDate(NoteBookProvider receiver, DateTime dateTime)
    {
      Receiver = receiver;
      CreationTime = dateTime;
    }

    /// <summary>
    /// This method calls needed method.
    /// </summary>
    public void Execute()
    {
      Receiver.SearchNoteByDate(CreationTime);
    }
  }
}