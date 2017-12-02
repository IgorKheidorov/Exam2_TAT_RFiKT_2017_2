using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBook
{
  /// <summary>
  /// This class of NoteBook which has one field List of notes.
  /// </summary>
  public class Notebook
  {
    private List<Note> ListOfNotes = new List<Note>();

    /// <summary>
    /// This method return note from notebook by index
    /// </summary>
    /// <param name="index">number interested us note from notebook</param>
    /// <returns>note by index</returns>
    public Note GetNoteByIndex(int index)
    {
      return ListOfNotes[index];
    }

    /// <summary>
    /// This method add note to notebook
    /// </summary>
    /// <param name="title">Title of data</param>
    /// <param name="data">data of this note</param>
    public void AddNote(String title, String data)
    {
      ListOfNotes.Add(new Note(title, data));
    }

    /// <summary>
    /// Override method ToString for this class
    /// </summary>
    /// <returns>String with all data of fields of this value</returns>
    public override String ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      for (int i = 0; i < ListOfNotes.Count; i++)
      {
        stringBuilder.Append(ListOfNotes[i]);
        stringBuilder.Append("\n");
      }
      return stringBuilder.ToString();
    }

    /// <summary>
    /// Override method GetHashCode for this class
    /// </summary>
    /// <returns>Identification number of this note</returns>
    public override int GetHashCode()
    {
      return this.ToString().GetHashCode();
    }

    /// <summary>
    /// Override method Equals for this class
    /// </summary>
    /// <param name="obj">object with which we want compare</param>
    /// <returns></returns>
    public override bool Equals(object obj)
    {
      return this.GetHashCode().Equals(obj.GetHashCode());
    }

    /// <summary>
    /// This method find equal data in notebook
    /// </summary>
    /// <returns>true if find or false if cant find equals data in notrbook</returns>
    public Boolean FindEqualsData(String data)
    {
      for (int i = 0; i < ListOfNotes.Count; i++)
      {
        if (ListOfNotes[i].Data.Equals(data))
        {
          return true;
        }
      }
      return false;
    }

    /// <summary>
    /// This method find equal time of note in notebook
    /// </summary>
    /// <returns>true if find or false if cant find equals time if note in notrbook</returns>
    public Boolean FindEqualsTime(String time)
    {
      for (int i = 0; i < ListOfNotes.Count; i++)
      {
        if (ListOfNotes[i].Time.ToString().Equals(time))
        {
          return true;
        }
      }
      return false;
    }
  }
}
