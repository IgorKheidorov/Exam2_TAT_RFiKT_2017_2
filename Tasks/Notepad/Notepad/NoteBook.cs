using System;
using System.Collections.Generic;
using System.Text;

namespace Notepad
{
  /// <summary>
  /// Class describes essense of notebook
  /// with list of notes.
  /// Contains unique id and
  /// date time of creating
  /// </summary>
  public class NoteBook
  {
    private static int id;

    public string Name { get; set; }
    public List<Note> Notes { get; set; }
    public DateTime Date { get; }
    public int Id { get; }

    /// <summary>
    /// Set field Name like input param
    /// Set current time in field date
    /// Set to notebook id
    /// </summary>
    /// <param name="name">new notebooks name</param>
    public NoteBook(string name)
    {
      Name = name;
      Notes = new List<Note>();
      Date = DateTime.Now;
      Id = id++;
    }

    /// <summary>
    /// Overrided equals method
    /// Check name and list notes fields in notebooks
    /// </summary>
    /// <param name="obj">checked on equality node</param>
    /// <returns>true all fields are equals, false otherwise</returns>
    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }

      NoteBook note = (NoteBook)obj;
      return (Name == note.Name) && (Notes == note.Notes);
    }

    /// <summary>
    /// Overrided get hashcode method
    /// Hashcode is date of creating in milliseconds
    /// </summary>
    /// <returns>Integer hashcode</returns>
    public override int GetHashCode()
    {
      return Date.Millisecond;
    }

    /// <summary>
    /// Overrided toString method
    /// Looks like id+title+date+content
    /// </summary>
    /// <returns>Integer hashcode</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder(Id).AppendLine();
      return sb.ToString();
    }
  }
}
