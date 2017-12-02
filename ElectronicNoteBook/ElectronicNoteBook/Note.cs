using System;
using System.Text;

namespace ElectronicNoteBook
{
  /// <summary>
  /// This class represents notes of notebook
  /// </summary>
  public class Note
  {
    public string Title { get; set; }
    public DateTime DateOfCreation { get; set; }
    public StringBuilder Notation { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }
      Note note = (Note)obj;
      return (Title == note.Title) && (DateOfCreation.Equals(note.DateOfCreation)) && (Notation.Equals(note.Notation));
    }

    public override int GetHashCode()
    {
      return DateOfCreation.Minute * DateOfCreation.Second * DateOfCreation.Millisecond / 1000;
    }

    public override string ToString()
    {
      StringBuilder output = new StringBuilder("Title: " + Title + "\n Date and time of creation: " + DateOfCreation.ToString() + "\n");
      output.Append(Notation);
      return output.ToString();
    }
  }
}
