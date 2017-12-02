using System;

namespace Test4
{
  /// <summary>
  /// This class displays information about notes in Notebook on the screen. 
  /// </summary>
  public class NoteBookConsoleView
  {
    /// <summary>
    /// This method displays information about one note on the screen.
    /// </summary>
    /// <param name="noteBook">Notebook which contains this note.</param>
    /// <param name="indexOFNote">
    /// The index of a note in a notebook, of information about which need to be displayed.
    /// </param>
    public void Print(NoteBook noteBook, int indexOFNote)
    {
      if (indexOFNote >= noteBook.ListOfNotes.Count || indexOFNote < 0)
      {
        throw new ArgumentOutOfRangeException();
      }

      Console.WriteLine(noteBook.ListOfNotes[indexOFNote].ToString());
    }

    /// <summary>
    /// This method displays information about all notes in notebook on the screen.
    /// </summary>
    /// <param name="noteBook">Notebook</param>
    public void Print(NoteBook noteBook)
    {
      foreach (Note note in noteBook.ListOfNotes)
      {
        Console.WriteLine(note.ToString());
      }
    }

    /// <summary>
    /// This method displays information about several notes in notebook on the screen.
    /// </summary>
    /// <param name="noteBook">Notebook.</param>
    /// <param name="indexNote">Index of note in the notebook.</param>
    public void Print(NoteBook noteBook, params int[] indexNote)
    {
      for (int i = 0; i < indexNote.Length; i++)
      {
        if (indexNote[i] >= noteBook.ListOfNotes.Count || indexNote[i] < 0)
        {
          throw new ArgumentOutOfRangeException();
        }
        Console.WriteLine(noteBook.ListOfNotes[indexNote[i]].ToString());
      }
    }
  }
}
