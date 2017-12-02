using System;

namespace TaskAboutNoteBook
{
  /// <summary>
  /// Representation of Add note command.
  /// </summary>
  public class AddNoteCommand : Command
  {
    private NoteBook noteBook;
    
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="noteBook">NoteBook for editing.</param>
    public AddNoteCommand(NoteBook noteBook)
    {
      this.noteBook = noteBook;
    }

    /// <summary>
    /// Executes command.
    /// </summary>
    public void Execute()
    {
      noteBook.AddNote(CreateNote());
    }

    /// <summary>
    /// Creates note.
    /// </summary>
    /// <returns>Entered from console note.</returns>
    private Note CreateNote()
    {      
      Console.WriteLine("Enter title :");
      string title = Console.ReadLine();
      Console.WriteLine("Enter data :");
      string data = Console.ReadLine();
      return new Note(data, title);
    }
  }
}
