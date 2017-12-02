using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicNotepad
{
  /// <summary>
  /// This is class for notebook.
  /// </summary>
  public class NoteBook
  {
    public string Name { get; set; }
    public List<Note> Content { get; set; }
    public DateTime CreationTime { get; set; }

    /// <summary>
    /// This is default constructor for NoteBook.
    /// </summary>
    public NoteBook()
    {
      Name = string.Empty;
      Content = new List<Note>();
      CreationTime = DateTime.Now;
    }

    /// <summary>
    /// This is constructor for NoteBook class with one parameter.
    /// </summary>
    /// <param name="name"> Name of the notebook </param>
    public NoteBook(string name)
    {
      Name = name;
      Content = new List<Note>();
      CreationTime = DateTime.Now;
    }

    /// <summary>
    /// This is constructor for NoteBook class with two parameters.
    /// </summary>
    /// <param name="name"> Name of the notebook </param>
    /// <param name="content"> Content of the notebook </param>
    public NoteBook(string name, List<Note> content)
    {
      Name = name;
      Content = new List<Note>(content);
      CreationTime = DateTime.Now;
    }

    /// <summary>
    /// This is override of ToString() method.
    /// </summary>
    /// <returns> String with information about notebook </returns>
    public override string ToString()
    {
      StringBuilder result = new StringBuilder();
      result.AppendLine("NoteBook name : " + Name);
      result.AppendLine("Time : " + CreationTime);
      result.AppendLine("Notebook content :\n");
      int i = 1;
      foreach (Note note in Content)
      {
        result.AppendLine(i++ + ".");
        result.AppendLine(note.ToString());
      }
      return result.ToString();
    }

    /// <summary>
    /// This method compares NoteBook with object.
    /// </summary>
    /// <param name="obj"> Any object </param>
    /// <returns> True if two objects are equal and false if they don't </returns>
    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }
      NoteBook noteBook = (NoteBook)obj;
      return (Name == noteBook.Name && Content.Count == noteBook.Content.Count && CreationTime == noteBook.CreationTime);
    }

    /// <summary>
    /// This method gets hash code for NoteBook.
    /// </summary>
    /// <returns> Hash code </returns>
    public override int GetHashCode()
    {
      int hashCode = 0;
      foreach (Note note in Content)
      {
        hashCode += note.GetHashCode();
      }
      return Name.GetHashCode() + hashCode + CreationTime.GetHashCode();
    }
  }
}