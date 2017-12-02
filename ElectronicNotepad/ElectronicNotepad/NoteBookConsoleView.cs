using System;

namespace ElectronicNotepad
{
  /// <summary>
  /// This is class for console outputs.
  /// </summary>
  public class NoteBookConsoleView
  {
    public NoteBook NotePad { get; private set; }

    /// <summary>
    /// This is constructor for NoteBookConsoleView with one parameter.
    /// </summary>
    /// <param name="noteBook"> Notebook </param>
    public NoteBookConsoleView(NoteBook noteBook)
    {
      NotePad = noteBook;
    }

    /// <summary>
    /// This method prints all information about notebook on console.
    /// </summary>
    public void Print()
    {
      Console.WriteLine(NotePad.ToString());
    }

    /// <summary>
    /// This method prints note on console.
    /// </summary>
    /// <param name="note"> Note </param>
    public void Print(Note note)
    {
      Console.WriteLine(note.ToString());
    }

    /// <summary>
    /// This method prints notes by index.
    /// </summary>
    /// <param name="index"> Notes numbers </param>
    public void Print(params int[] index)
    {
      for (int i = 0; i < index.Length; i++)
      {
        if (index[i] < 0 || NotePad.Content.Count <= index[i])
        {
          throw new ArgumentException();
        }
        Console.WriteLine((i + 1) + ".\n" + NotePad.Content[index[i]].ToString());
      }
    }
  }
}