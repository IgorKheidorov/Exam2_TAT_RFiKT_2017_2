using System;

namespace Test4
{
  /// <summary>
  /// This class help to creates note.
  /// </summary>
  public class NoteProvider
  {
    /// <summary>
    /// In this method user enters name of note.
    /// </summary>
    /// <returns>Returns name of note.</returns>
    public string EnterName()
    {
      Console.WriteLine("Enter name of note:");
      return Console.ReadLine();
    }

    /// <summary>
    /// In this method user enters data of note.
    /// </summary>
    /// <returns>Returns data of note.</returns>
    public string EnterData()
    {
      Console.WriteLine("Enter data:");
      return Console.ReadLine();
    }

    /// <summary>
    /// This method enters date of creation of notebook.
    /// </summary>
    /// <returns>Returns date of creation of notebook.</returns>>
    public DateTime EnterDateOfCreation()
    {
      return new DateTime();
    }
  }
}
