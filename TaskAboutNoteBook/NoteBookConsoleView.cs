using System;
using System.Collections.Generic;
using System.Text;

namespace TaskAboutNoteBook
{

  /// <summary>
  /// Prints information about notebook to console.
  /// </summary>
  public class NoteBookConsoleView
  {
    private NoteBookProvider noteBookProvider;

    /// <summary>
    /// Creates an instance of NoteBookConsleView.
    /// </summary>
    /// <param name="noteBook">NoteBook to view.</param>
    public NoteBookConsoleView(NoteBookProvider noteBookProvider)
    {
      this.noteBookProvider = noteBookProvider;
    }

    /// <summary>
    /// Prints all notes in notebook.
    /// </summary>
    public string Print()
    {
      StringBuilder result = new StringBuilder();
      foreach (Note note in noteBookProvider.NoteBook.Notes)
      {
        result.Append(note.ToString());
      }
      return result.ToString();
    }

    /// <summary>
    /// Prints specify amount of notes in notebook from the begining.
    /// </summary>
    /// <param name="amountOfNotes">Amount of notes to print.</param>
    public string Print(int amountOfNotes)
    {
      if (amountOfNotes > noteBookProvider.NoteBook.Notes.Count)
      {
        throw new ArgumentException();
      }
      StringBuilder result = new StringBuilder();
      List<Note> notes = noteBookProvider.NoteBook.Notes;
      for (int i = 0; i < amountOfNotes; i++)
      {
        result.AppendLine(notes[i].ToString());
      }
      return result.ToString();
    }
  }
}
