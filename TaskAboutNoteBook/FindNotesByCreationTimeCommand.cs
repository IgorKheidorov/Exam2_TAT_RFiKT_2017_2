using System;
using System.Collections.Generic;

namespace TaskAboutNoteBook
{
  public class FindNotesByCreationTimeCommand : Command
  {
    /// <summary>
    /// Represtation of find notes by creation time command.
    /// Finds notes by creation time.
    /// </summary>
    private NoteBookProvider noteBookProvider;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="noteBookProvider">Provides data from notebook.</param>
    public FindNotesByCreationTimeCommand(NoteBookProvider noteBookProvider)
    {
      this.noteBookProvider = noteBookProvider;
    }

    /// <summary>
    /// Executes command.
    /// </summary>
    public void Execute()
    {
      Console.WriteLine("Enter cretion time of  note :");
      List<Note> notes = this.FindNotesByCreationTime(Console.ReadLine());
      foreach (Note note in notes)
      {
        Console.WriteLine(note.ToString());
      }   
    }

    /// <summary>
    /// FInd notes by creation time.
    /// </summary>
    /// <param name="creationTime">Creation timeof notes to find.</param>
    /// <returns>List of nots with specify creation time.</returns>
    public List<Note> FindNotesByCreationTime(string creationTime)
    {
      List<Note> result = new List<Note>();
      foreach (Note note in noteBookProvider.NoteBook.Notes)
      {
        if (creationTime.Equals(note.CreationTime))
        {
          result.Add(note);
        }
      }
      return result;
    }
  }
}
