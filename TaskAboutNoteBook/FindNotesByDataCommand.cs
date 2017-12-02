using System;
using System.Collections.Generic;


namespace TaskAboutNoteBook
{
  /// <summary>
  /// Representation of find notes by data command.
  /// Finds notes by data.
  /// </summary>
  public class FindNotesByDataCommand : Command
  {
    private NoteBookProvider noteBookProvider;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="noteBookProvider">Instance of NoteBookProvider</param>
    public FindNotesByDataCommand(NoteBookProvider noteBookProvider)
    {
      this.noteBookProvider = noteBookProvider;
    }

    /// <summary>
    /// Executes command.
    /// </summary>
    public void Execute()
    {
      Console.WriteLine("Enter note data :");
      List<Note> notes = this.FindNotesByData(Console.ReadLine());
      foreach (Note note in notes)
      {
        Console.WriteLine(note.ToString());
      }
    }

    public List<Note> FindNotesByData(string noteData)
    {
      List<Note> result = new List<Note>();
      foreach (Note note in noteBookProvider.NoteBook.Notes)
      {
        if (noteData.Equals(note.Data))
        {
          result.Add(note);
        }
      }
      return result;
    }
  }
}
