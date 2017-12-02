using System;

using System.Text;


namespace TaskAboutNoteBook
{
  /// <summary>
  /// Representation of note.
  /// </summary>
  public class Note
  {
    private string data;
    private string title;
    private string creationTime;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="title"></param>
    public Note(string data, string title)
    {
      this.data = data;
      this.title = title;
      this.creationTime = DateTime.Now.ToString();
    }

    /// <summary>
    /// Returns data.
    /// </summary>
    public string Data
    {
      get
      {
        return data;
      }
    }

    /// <summary>
    /// Returns creation time.
    /// </summary>
    public string CreationTime
    {
      get
      {
        return creationTime;
      }
    }

    /// <summary>
    /// Returns title.
    /// </summary>
    public string Title
    {
      get
      {
        return title;
      }
    }

    /// <summary>
    /// Compares this instance and another.
    /// </summary>
    /// <param name="obj">Another object.</param>
    /// <returns>True if equals;otherwise false.</returns>
    public override bool Equals(object obj)
    {
      Note note = null;
      if (obj is Note)
      {
        note = (Note)obj;
      }
      else
      {
        throw new ArgumentException();
      }
      return this.data.Equals(note.data) && this.title.Equals(note.title) && this.creationTime.Equals(note.creationTime);
    }

    /// <summary>
    /// Returns hash code of instance.
    /// </summary>
    /// <returns>Hash code of instance.</returns>
    public override int GetHashCode()
    {
      return this.data.GetHashCode() + this.title.GetHashCode() + this.creationTime.GetHashCode();
    }

    /// <summary>
    /// Returns string representation of instance.
    /// </summary>
    /// <returns>string representation of instance</returns>
    public override string ToString()
    {
      StringBuilder result = new StringBuilder("Title : ");
      result.Append(this.title).AppendLine();
      result.Append("Date of creation : ");
      result.Append(this.creationTime).AppendLine();
      result.Append("Data : ");
      result.Append(this.data).AppendLine();
      return result.ToString();
    }
  }
}
