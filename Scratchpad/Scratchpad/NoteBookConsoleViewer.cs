using System;
using System.Text;

namespace Scratchpad
{
  /// <summary>
  /// Class for console print
  /// </summary>
  public class NoteBookConsoleViewer
  {
    NoteBook Notebook { get; }

    /// <summary>
    /// Trivial constructor.
    /// </summary>
    /// <param name="note"> Initialization of field</param>
    public NoteBookConsoleViewer(NoteBook notebook)
    {
      Notebook = notebook;
    }

    /// <summary>
    /// For printing some kind of notes from the NoteBook
    /// </summary>
    /// <param name="note"> Notes for printing</param>
    public void PrintNoteBook()
    {
      if (Notebook != null)
      {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < Notebook.NewNoteBook.Count; i++)
        {
          builder.Append(Notebook.NewNoteBook[i] + "\n");
        }
        Console.Write(builder.ToString());
      }
      else
      {
        Console.Write("There are no any notes for printing.");
      }
    }
  }
}
