using System;
using System.IO;

namespace TaskAboutNoteBook
{
  /// <summary>
  /// Provides notebook and data for it.
  /// </summary>
  public class NoteBookProvider
  {
    private StreamReader streamReader;
    private NoteBook noteBook;

    /// <summary>
    /// Returns notebook.
    /// </summary>
    public NoteBook NoteBook
    {
      get
      {
        return noteBook;
      }
    }

    /// <summary>
    /// Creates notebook.
    /// </summary>
    /// <returns>New notebook.</returns>
    public NoteBook CreateNoteBook()
    {
      noteBook = new NoteBook();
      return noteBook;
    }

    /// <summary>
    /// Load data from file to notebook.
    /// </summary>
    /// <param name="path">Path of file.</param>
    /// <returns>true if data loaded;otherwise false.</returns>
    public bool LoadNoteBookFromFile(string path)
    {      
      using (streamReader = new StreamReader(path))
      {
        string currentString = String.Empty;
        while (!streamReader.EndOfStream)
        {
          noteBook.AddNote(LoadNoteFromFile()); 
        }      
      }
      return true;
    }

    private Note LoadNoteFromFile()
    {
      string title = streamReader.ReadLine();
      string data = streamReader.ReadLine();
      return new Note(data, title);
    }  
  }
}
