using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAboutNoteBook
{
  /// <summary>
  /// Representation of notebook.
  /// </summary>
  public class NoteBook
  {
    private List<Note> notes { get; }
    private DateTime creationTime;

   

    /// <summary>
    /// Default constructor.
    /// </summary>
    public NoteBook()
    {
      this.notes = new List<Note>();
      this.creationTime = DateTime.Now;
    }

    /// <summary>
    /// Returns list of notes.
    /// </summary>
    public List<Note> Notes
    {
      get
      {
        return notes;
      }
    }

    /// <summary>
    /// Adds note to the notebook.
    /// </summary>
    /// <param name="note">Note to add.</param>
    public void AddNote(Note note)
    {
      notes.Add(note);
    }


    /// <summary>
    /// Compares this instance and another.
    /// </summary>
    /// <param name="obj">Another object.</param>
    /// <returns>True if equals;otherwise false.</returns>
    public override bool Equals(object obj)
    {
      NoteBook noteBook = null;
      if (obj is NoteBook)
      {
        noteBook = (NoteBook)obj;
      }
      else
      {
        throw new ArgumentException();
      }
      return this.notes.Equals(noteBook.notes)  && this.creationTime.Equals(noteBook.creationTime);
    }

    /// <summary>
    /// Returns hash code of instance.
    /// </summary>
    /// <returns>Hash code of instance.</returns>
    public override int GetHashCode()
    {
      return this.notes.GetHashCode()  + this.creationTime.GetHashCode();
    }

    // <summary>
    /// Returns string representation of instance.
    /// </summary>
    /// <returns>string representation of instance</returns>
    public override string ToString()
    {
      StringBuilder result = new StringBuilder("Date of creation : ");
      result.Append(this.creationTime.ToString()).AppendLine();
      return result.ToString();
    }
  }
}
