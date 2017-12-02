using System;
using System.IO;

namespace TaskAboutNoteBook
{
  /// <summary>
  /// Writes notebook into file.
  /// </summary>
  public class WriteNoteBookIntoFileCommand : Command
  {
    private StreamWriter streamWriter;
    private NoteBookProvider noteBookProvider;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="noteBookProvider">Instance of NoteBookProvier.Provides notebook</param>
    public WriteNoteBookIntoFileCommand(NoteBookProvider noteBookProvider)
    {   
      this.noteBookProvider = noteBookProvider;
    }

    /// <summary>
    /// Executes command.
    /// </summary>
    public void Execute()
    {
      Console.WriteLine("Enter path of file :");
      this.WriteNoteBookIntoFile(Console.ReadLine());
    }

    public bool WriteNoteBookIntoFile(string path)
    {
      using (streamWriter = new StreamWriter(path))
      {
        foreach (Note note in noteBookProvider.NoteBook.Notes)
        {
          streamWriter.WriteLine(note.Title);
          streamWriter.WriteLine(note.Data);
          streamWriter.WriteLine(note.CreationTime);
        }
      }
      return true;
    }

    private void WriteNoteIntoFile(Note note)
    {
      streamWriter.WriteLine(note.Title);
      streamWriter.WriteLine(note.Data);
      streamWriter.WriteLine(note.CreationTime);
    }
  }
}
