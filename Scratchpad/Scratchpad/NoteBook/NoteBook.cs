using System.Collections.Generic;
using System.Text;

namespace Scratchpad
{
  /// <summary>
  /// Realization of NoteBook. 
  /// There are also implementation of methods for adding new note to NoteBook and to print NoteBook
  /// </summary>
  public partial class NoteBook
  {
    public List<Note> NewNoteBook;
    public int Count { get; private set; }

    /// <summary>
    /// Trivial constructor.
    /// </summary>
    /// <param name="note"> Initialization of field</param>
    public NoteBook(string userNote)
    {
      NewNoteBook = new List<Note>();
      Note note = new Note(userNote);
    }

    /// <summary>
    /// Default constructor
    /// </summary>
    public NoteBook()
    { }

    /// <summary>
    /// For adding new note to NoreBook
    /// </summary>
    /// <param name="newNode">What we want to add </param>
    public void AddNewNote(string newNote)
    {
      NewNoteBook.Add(new Note(newNote));
      Count++;
    }

    /// <summary>
    /// For representing NoteBook in string format
    /// </summary>
    /// <returns>String representation of NoteBook</returns>
    public override string ToString()
    {
      StringBuilder builder = new StringBuilder();
      foreach (var element in NewNoteBook)
      {
        builder.Append(element.ToString());
      }
      return builder.ToString();
    }

    /// <summary>
    /// For getting hashCode
    /// </summary>
    /// <returns>Get hash of Note</returns>
    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    /// <summary>
    /// The fields comparison of two objects of NoteBook type
    /// </summary>
    /// <param name="obj">Object wich we want to compare</param>
    /// <returns> True if the objects are equals </returns>
    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }
  }
}


