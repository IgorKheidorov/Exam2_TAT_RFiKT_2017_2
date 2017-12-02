using System;
using System.Collections.Generic;

namespace Test4
{
  /// <summary>
  /// This class helps to create notebook.
  /// </summary>
  public class NoteBookProvider
  {
    /// <summary>
    /// In this method user enters name of notebook.
    /// </summary>
    /// <returns>Returns entered name of notebook.</returns>
    public string EnterName()
    {
      Console.WriteLine("Enter name of notebook:");
      return Console.ReadLine();
    }

    /// <summary>
    /// This method creates list of notes.
    /// </summary>
    /// <returns>Returns list of notes.</returns>
    public List<Note> EnterNotes()
    {
      NoteProvider noteProvider = new NoteProvider();
      string yesOrNo = "Y";
      List<Note> notes = new List<Note>();

      while (yesOrNo == "Y")
      {
        notes.Add(new Note(noteProvider.EnterName(),
          noteProvider.EnterData(), noteProvider.EnterDateOfCreation()));

        Console.WriteLine("Do you want enter note?(Y/N");
        yesOrNo = Console.ReadLine();
      }

      return notes;
    }

    /// <summary>
    /// This method enters date of creation of notebook.
    /// </summary>
    /// <returns>Returns date of creation of notebook.</returns>
    public DateTime EnterDateOfCreation()
    {
      return new DateTime();
    }
  }
}
