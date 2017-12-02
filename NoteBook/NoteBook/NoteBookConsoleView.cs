using System;

namespace NoteBook
{
  /// <summary>
  /// This class of NoteBook for working with console view
  /// </summary>
  public class NoteBookConsoleView
  {
    /// <summary>
    ///This method output all data of notebook with all notes in console
    /// </summary>
    /// <param name="noteBook">notebook wich we want to output</param>
    public void Print(Notebook noteBook)
    {
      Console.WriteLine(noteBook.ToString());
    }

    /// <summary>
    /// This method output data of notebook for number this note in notebook
    /// </summary>
    /// <param name="noteBook">notebook from wich we want to output data</param>
    /// <param name="numberOfNote">number of note which we want output</param>
    public void Print(Notebook noteBook, int numberOfNote)
    {
      Console.WriteLine(noteBook.GetNoteByIndex(numberOfNote).ToString());
    }

    /// <summary>
    /// This method output data of notebook for numbers notes of notebook
    /// </summary>
    /// <param name="noteBook">notebook from wich we want to output data</param>
    /// <param name="numbersOfNote">numbers of notes which we want output</param>
    public void Print(Notebook noteBook, int[] numbersOfNote)
    {
      for (int i = 0; i < numbersOfNote.Length; i++)
      {
        Console.WriteLine(noteBook.GetNoteByIndex(numbersOfNote[i]).ToString());
      }
    }
  }
}
