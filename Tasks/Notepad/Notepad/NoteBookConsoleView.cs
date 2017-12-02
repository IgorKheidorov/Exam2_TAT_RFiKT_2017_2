using System;

namespace Notepad
{
  /// <summary>
  /// Class contains methods
  /// to print current notebook in field NoteBook
  /// in console
  /// </summary>
  public class NoteBookConsoleView
  {
    public NoteBook NoteBook { get; set; }

    /// <summary>
    /// Set current notebook in console viewer
    /// </summary>
    /// <param name="noteBook"></param>
    public NoteBookConsoleView(NoteBook noteBook)
    {
      NoteBook = noteBook;
    }

    /// <summary>
    /// Print all notes in notebook
    /// </summary>
    public void Print()
    {
      foreach (var note in NoteBook.Notes)
      {
        Console.WriteLine(note.ToString());
      }
    }

    /// <summary>
    /// Print some notes in notebook
    /// Throws if needed count of notes is invalid
    /// </summary>
    /// <param name="count">Count of printed notes</param>
    public void Print(int count)
    {
      if (count <= 0 || count > NoteBook.Notes.Count)
      {
        throw new InvalidOperationException();
      }
      for (int i = 0; i < count; i++)
      {
        Console.WriteLine(NoteBook.Notes[i].ToString());
      }
    }
  }
}
