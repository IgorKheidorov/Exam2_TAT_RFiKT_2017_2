
using System;
using System.Text;

namespace Notepad
{
  /// <summary>
  /// The essence of an entry in a notebook
  /// Contains unique id,
  /// date time of creating,
  /// title and content
  /// </summary>
  public class Note
  {
    public DateTime Date { get; }
    public string Title { get; set; }
    public string Content { get; set; }
   
    /// <summary>
    /// Create new Note with definited title
    /// Set current time in field Date
    /// Set Id
    /// </summary>
    /// <param name="title"></param>
    public Note(string title)
    {
      Title = title;
      Date = DateTime.Now;
    }

    /// <summary>
    /// Overrided equals method
    /// Check all fields in nodes
    /// </summary>
    /// <param name="obj">checked on equality node</param>
    /// <returns>true all fields are equals, false otherwise</returns>
    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
        return false;

      Note note = (Note)obj;
      return (Date == note.Date) && (Title == note.Title) && (Content == note.Content);
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
    /// Looks like title+date+content
    /// </summary>
    /// <returns>Integer hashcode</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      return sb.AppendLine(Title).AppendLine(Date.ToLongDateString()).AppendLine(Content).ToString();
    }
  }
}
