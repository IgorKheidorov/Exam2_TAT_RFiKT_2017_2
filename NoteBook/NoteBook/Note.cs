using System;

namespace Notebook
{
  /// <summary>
  /// Describes composit element of note book.
  /// </summary>
  class Note
  {
    public string Value { get; set; }
    public string Title { get; set; }
    public readonly DateTime timeOfCreation;

    /// <summary>
    /// All constructors besides last one initialize timeOfCreation field
    /// as current time.
    /// </summary>
    public Note()
    {
      Value = string.Empty;
      Title = string.Empty;
      timeOfCreation = DateTime.Now;
    }
    public Note(string value)
    {
      Value = value;
      Title = string.Empty;
      timeOfCreation = DateTime.Now;
    }
    public Note(string value, string title)
    {
      Value = value;
      Title = title;
      timeOfCreation = DateTime.Now;
    }
    public Note(string value, string title, DateTime time)
    {
      Value = value;
      Title = title;
      timeOfCreation = time;
    }
    /// <summary>
    /// Override of default implementation of Equals method.
    /// </summary>
    /// <param name="obj">
    /// Object to compare.
    /// </param>
    /// <returns>
    /// True if objects are equivalent,otherwise false.
    /// </returns>
    public override bool Equals(object obj)
    {
      if (obj == null)
      {
        return false;
      }
      Note note = obj as Note;
      if (note == null)
      {
        return false;
      }
      else
      {
        return this.Value == note.Value && this.Title == note.Title && this.timeOfCreation == note.timeOfCreation;
      }
    }
    /// <summary>
    /// Override of default implementation of ToString method.
    /// </summary>
    /// <returns>
    /// String representation of Note.
    /// </returns>
    public override string ToString()
    {
      return timeOfCreation + "\n" + Title + "\n" + Value;
    }
    /// <summary>
    /// Override of default implementation of GetHashCode method.
    /// </summary>
    /// <returns>
    /// Hash code of this Note.
    /// </returns>
    public override int GetHashCode()
    {
      return Value.GetHashCode() + Title.GetHashCode() + timeOfCreation.GetHashCode();
    }
  }
}
