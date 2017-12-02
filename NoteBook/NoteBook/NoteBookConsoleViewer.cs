using System;

namespace Notebook
{
  /// <summary>
  /// Implements write into console notes from note book.
  /// </summary>
  public class NoteBookConsoleViewer
  {
    NoteBook noteBook;

    public NoteBookConsoleViewer(NoteBook noteBook)
    {
      this.noteBook = noteBook;
    }
    /// <summary>
    /// Writes into console all notes from note book.
    /// </summary>
    public void Print()
    {
      foreach (var note in noteBook.Notes)
      {
        Console.Write(note + "\n");
      }
    }
    /// <summary>
    /// Writes into console several notes from note book
    /// </summary>
    /// <param name="count">
    /// Number of notes to output.
    /// </param>
    public void Print(int count)
    {
      if (count > noteBook.Notes.Count)
      {
        count = noteBook.Notes.Count;
      }
      for (int i = 0; i < count; i++)
      {
        Console.Write(noteBook.Notes[i] + "\n");
      }
    }
  }
}
