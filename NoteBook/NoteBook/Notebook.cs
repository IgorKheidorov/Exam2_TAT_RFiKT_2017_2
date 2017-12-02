using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notebook
{
  /// <summary>
  /// Describes the substance of note book and methods to work with it.
  /// </summary>
  public class NoteBook
  {
    public List<Note> Notes { get; set; }
    public void CreateNoteBook()
    {
      Notes = new List<Note>();
    }
    /// <summary>
    /// Adds note to this note book.
    /// </summary>
    /// <param name="value">
    /// Value of note.
    /// </param>
    /// <param name="title">
    /// Title of note.
    /// </param>
    public void AddNote(string value, string title)
    {
      Notes.Add(new Note(value, title));
    }
    /// <summary>
    /// Adds note to this note book.
    /// </summary>
    /// <param name="value">
    /// Value of note.
    /// </param>
    /// <param name="title">
    /// Title of note.
    /// </param>
    /// <param name="time">
    /// Time of creation of note.
    /// </param>
    public void AddNote(string value, string title,DateTime time )
    {
      Notes.Add(new Note(value, title, time));
    }
    /// <summary>
    /// Searching first note with concrete value.
    /// </summary>
    /// <param name="value">
    /// Value to search.
    /// </param>
    /// <returns>
    /// Note with required value.
    /// </returns>
    public Note SearchByValue(string value)
    {
      foreach (var note in Notes)
      {
        if (note.Value == value)
        {
          return note;
        }
      }
      return null;
    }
    /// <summary>
    /// Searching first note with concrete time of creation.
    /// </summary>
    /// <param name="value">
    /// Value to search.
    /// </param>
    /// <returns>
    /// Note with required time of creation or null if its wasnt found.
    /// </returns>
    public Note SearchByTimeOfCreation(DateTime time)
    {
      foreach (var note in Notes)
      {
        if (note.timeOfCreation.Equals(time))
        {
          return note;
        }
      }
      return null;
    }
    /// <summary>
    /// Write current note book into file
    /// </summary>
    /// <param name="path">
    /// Path to file to write.
    /// </param>
    public void WriteIntoFile(string path)
    {
      using (StreamWriter writer = new StreamWriter(path))
      {
        foreach (var note in Notes)
        {
          writer.WriteLine(note.timeOfCreation);
          writer.WriteLine(note.Title);
          writer.WriteLine(note.Value);
        }
      }
    }
    
    /// <summary>
    /// Reads note book from file.
    /// </summary>
    /// <param name="path">
    /// Path to file to read from.
    /// </param>

    // TODO : Implement file validator.
    public void ReadFromFile(string path)
    {
      using (StreamReader reader = new StreamReader(path))
      {
        while (!reader.EndOfStream)
        {
          DateTime time = Convert.ToDateTime(reader.ReadLine());
          string title = reader.ReadLine();
          string value = reader.ReadLine();
          if (title == null || string.IsNullOrEmpty(value))
          {
            throw new Exception("File contains wrong information!");
          }
          Notes.Add(new Note(value, title, time));
        }
      }
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
      NoteBook notebook = obj as NoteBook;
      if (notebook == null)
      {
        return false;
      }
      if (notebook.Notes.Count == this.Notes.Count)
      {
        for (int i = 0; i < Notes.Count; i++)
        {
          if (!Notes[i].Equals(notebook.Notes[i]))
          {
            return false;
          }
        }
        return true;
      }
      return false;
    }
    /// <summary>
    /// Override of default implementation of ToString method.
    /// </summary>
    /// <returns>
    /// String representation of NoteBook.
    /// </returns>
    public override string ToString()
    {
      StringBuilder builder = new StringBuilder("Titles of this notebook:\n");
      foreach (var note in Notes)
      {
        builder.Append(note);
        builder.Append('\n');
      }
      return builder.ToString();
    }
    /// <summary>
    /// Override of default implementation of GetHashCode method.
    /// </summary>
    /// <returns>
    /// Hash code of this NoteBook.
    /// </returns>
    public override int GetHashCode()
    {
      return Notes.GetHashCode();
    }
  }
}
