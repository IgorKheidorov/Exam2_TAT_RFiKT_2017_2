using System;
using System.Text;

namespace ElectronicNoteBook
{
  /// <summary>
  /// This class represents notes of notebook
  /// </summary>
  public class Note
  {
    public DateTime DateOfCreation { get; set; }
    public StringBuilder Notation { get; set; }

    public Note ()
    {
      DateOfCreation = DateTime.Now;
      Notation = new StringBuilder(String.Empty);
    }
    public Note(DateTime dateTimeOfCreation, StringBuilder data)
    {
      DateOfCreation = dateTimeOfCreation;
      Notation = data;
    }

    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }
      Note note = (Note)obj;
      return (DateOfCreation.Equals(note.DateOfCreation)) && (Notation.Equals(note.Notation));
    }

    public override int GetHashCode()
    {
      return DateOfCreation.Minute * DateOfCreation.Second * DateOfCreation.Millisecond / 1000;
    }

    public override string ToString()
    {
      StringBuilder output = new StringBuilder("Date and time of creation: " + DateOfCreation.ToString() + "\n");
      output.Append(Notation);
      return output.ToString();
    }
  }
}
