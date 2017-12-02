using System;
using System.Text;

namespace ElectronicNotepad
{
  /// <summary>
  /// This is class for note information.
  /// </summary>
  public class Note
  {
    public string Name { get; set; }
    public string Content { get; set; }
    public DateTime CreationTime { get; set; }

    /// <summary>
    /// This is default constructor for Note.
    /// </summary>
    public Note()
    {
      Name = string.Empty;
      Content = null;
      CreationTime = DateTime.Now;
    }

    /// <summary>
    /// This is constructor for Note class with parameters.
    /// </summary>
    /// <param name="name"> Name of the note </param>
    /// <param name="content"> content of the note </param>
    public Note(string name, string content)
    {
      Name = name;
      Content = content;
      CreationTime = DateTime.Now;
    }

    /// <summary>
    /// This is override of ToString() method.
    /// </summary>
    /// <returns> String with information </returns>
    public override string ToString()
    {
      StringBuilder result = new StringBuilder();
      result.AppendLine("Note name : " + Name);
      result.AppendLine("Data :");
      result.AppendLine(Content);
      result.AppendLine("Time : " + CreationTime);
      return result.ToString();
    }

    /// <summary>
    /// This method compares Note with object.
    /// </summary>
    /// <param name="obj"> Any object </param>
    /// <returns> True if two objects are equal and false if they don't </returns>
    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }
      Note note = (Note)obj;
      return (Name == note.Name && Content == note.Content && CreationTime == note.CreationTime);
    }

    /// <summary>
    /// This method gets hash code for Note.
    /// </summary>
    /// <returns> Hash code </returns>
    public override int GetHashCode()
    {
      return Name.GetHashCode() + Content.GetHashCode() + CreationTime.GetHashCode();
    }
  }
}