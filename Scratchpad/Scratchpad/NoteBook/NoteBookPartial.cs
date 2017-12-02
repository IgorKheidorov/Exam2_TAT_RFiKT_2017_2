using System;
using System.Collections.Generic;

namespace Scratchpad
{
  /// <summary>
  /// Сontinuation of NoteBook
  /// </summary>
  public partial class NoteBook
  {
    /// <summary>
    /// For searching the note by date
    /// </summary>
    /// <param name="value">The value by which you search</param>
    /// <returns>String where it meetings</returns>
    public string FindNoteByDate(DateTime data)
    {
      for (int i = 0; i < NewNoteBook.Count; i++)
      {
        if (NewNoteBook[i].Date.Equals(data))
        {
          return NewNoteBook[i].Record.ToString();
        }
      }
      return null;
    }

    /// <summary>
    /// For searching the note by value
    /// </summary>
    /// <param name="value">The value by which you search</param>
    /// <returns>String where it meetings</returns>
    public string FindNoteByValue(string value)
    {
      for (int i = 0; i < NewNoteBook.Count; i++)
      {
        if (NewNoteBook[i].Record.Equals(value))
        {
          return NewNoteBook[i].ToString();
        }
      }
      return null;
    }

    /// <summary>
    /// For creation the NoteBook
    /// </summary>
    /// <param name="data">Create the NoteBook with this record</param>
    public void CreateNewNoteBook(string data)
    {
      NewNoteBook = new List<Note>
      {
        new Note(data)
      };
      Count++;
    }
  }
}