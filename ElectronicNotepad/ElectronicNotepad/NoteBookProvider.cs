using System;
using System.IO;

namespace ElectronicNotepad
{
  /// <summary>
  /// This is provider for command pattern.
  /// </summary>
  public class NoteBookProvider
  {
    public NoteBook NotePad { get; set; }

    /// <summary>
    /// This method creates notebook.
    /// </summary>
    /// <returns> created otebook </returns>
    /// <param name="noteBookName"> Inputted noteBookName </param>
    public NoteBook CreateNoteBook(string noteBookName)
    {
      NotePad = new NoteBook(noteBookName);
      return NotePad;
    }

    /// <summary>
    /// This method adds note to notebook.
    /// </summary>
    /// <param name="note"> Note </param>
    public void AddNote(Note note)
    {
      NotePad.Content.Add(note);
    }

    /// <summary>
    /// This method finds note by inputted text.
    /// </summary>
    /// <param name="text"> Inputted text </param>
    /// <returns> Needed note </returns>
    public Note SearchNoteByContext(string text)
    {
      Note neededNote = null;
      foreach (Note note in NotePad.Content)
      {
        if (note.Content.Equals(text))
        {
          return note;
        }
      }
      return neededNote;
    }

    /// <summary>
    /// This method finds note by inputted date.
    /// </summary>
    /// <param name="text"> Inputted date </param>
    /// <returns> Needed note </returns>
    public Note SearchNoteByDate(DateTime dateTime)
    {
      Note neededNote = null;
      foreach (Note note in NotePad.Content)
      {
        if (note.CreationTime.Equals(dateTime))
        {
          return note;
        }
      }
      return neededNote;
    }

    /// <summary>
    /// This method displays all information from notebook.
    /// </summary>
    public void DisplayNoteBook()
    {
      Console.WriteLine(NotePad.ToString());
    }

    /// <summary>
    /// This method writes notebook to the file.
    /// </summary>
    public void WriteNoteBookToTheFile()
    {
      using (StreamWriter streamWriter = new StreamWriter("NoteBook.txt"))
      {
        streamWriter.Write(NotePad.ToString());
      }
    }
  }
}