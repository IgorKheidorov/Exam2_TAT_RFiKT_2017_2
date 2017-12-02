using System.Text;
using System;

namespace Test4
{
  /// <summary>
  /// This class realizes note.
  /// </summary>
  public class Note
  {
    private string nameOfNote;
    private string data;
    private string dateOfCreation;

    /// <summary>
    /// This constructor determines fields of class.
    /// </summary>
    /// <param name="nameOfNote">Name of note.</param>
    /// <param name="data">Data in the note.</param>
    /// <param name="dateOfCreation">Date of creation of note.</param>
    public Note(string nameOfNote, string data, DateTime dateOfCreation)
    {
      this.nameOfNote = nameOfNote;
      this.data = data;
      this.dateOfCreation = dateOfCreation.ToString();
      validateNote();
    }

    /// <summary>
    /// This method checks whether note and object are equal.
    /// </summary>
    /// <param name="obj">The second object with which a comparison is made.</param>
    /// <returns>Returns true if objects are equal, and false if not.</returns>
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

      return nameOfNote == note.nameOfNote
        && data == note.data && dateOfCreation == note.dateOfCreation;
    }

    /// <summary>
    /// This method returns hash of note.
    /// </summary>
    /// <returns>Returns hash of note.</returns>
    public override int GetHashCode()
    {
      return nameOfNote.GetHashCode() + data.GetHashCode() + dateOfCreation.GetHashCode();
    }

    /// <summary>
    /// This method returns information about note.
    /// </summary>
    /// <returns>Returns string with information about note.</returns>
    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("Name of note: ");
      stringBuilder.Append(nameOfNote);
      stringBuilder.Append(", date of creation: ");
      stringBuilder.Append(dateOfCreation);
      return stringBuilder.ToString();
    }

    private void validateNote()
    {
      if (nameOfNote == String.Empty)
      {
        throw new ArgumentException();
      }
    }

    public string Data { get { return data; } }
  }
}
