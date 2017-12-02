using System;

namespace Scratchpad
{
  /// <summary>
  ///  Realization of Note for using it in NoteBook. 
  /// </summary>
  public partial class Note
  {
    private static readonly int HASHNUMBER = 23; 

    public string Record { get; set; }
    public DateTime Date { get; set; }

    /// <summary>
    /// Trivial constructor with 
    /// getting a System.DateTime object that is set to the current date and time on this computer
    /// </summary>
    /// <param name="record"> The value of note</param>
    public Note(string record)
    {
      Record = record;
      Date = DateTime.Now;
    }

    /// <summary>
    /// Trivial constructor
    /// </summary>
    /// <param name="record">The value of note</param>
    /// <param name="date">The data of note</param>
    public Note(string record, DateTime date)
    {
      Record = record;
      Date = date;
    }
  }
}