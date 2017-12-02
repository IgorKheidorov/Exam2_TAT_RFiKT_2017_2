﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicNoteBook
{
  /// <summary>
  /// This class represents notebook
  /// </summary>
  public class NoteBook
  {
    public List<Note> Notations { get; set; }
    public DateTime DateOfCreation { get; set; }
    public int Id { get; set; }

    public NoteBook()
    {
      Id = 0;
      Notations = new List<Note>();
    }
    public NoteBook (int idOfNoteBook, DateTime dateTimeOfcreation)
    {
      DateOfCreation = dateTimeOfcreation;
      Id = idOfNoteBook;
      Notations = new List<Note>();
    }

    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }
      NoteBook noteBook = (NoteBook)obj;
      return Notations.Equals(noteBook.Notations) && DateOfCreation.Equals(noteBook.DateOfCreation) && Id == noteBook.Id;
    }

    public override int GetHashCode()
    {
      return DateOfCreation.Second * DateOfCreation.Minute * Id;
    }

    public override string ToString()
    {
      StringBuilder output = new StringBuilder("NoteBook id# " + Id + "\n Date and Time of creation: " + DateOfCreation + "\n");
      foreach (Note note in Notations)
      {
        output.Append(note.ToString());
        output.Append("\n");
      }
      return output.ToString();
    }
  }
}
