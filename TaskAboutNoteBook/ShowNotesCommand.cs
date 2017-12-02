using System;


namespace TaskAboutNoteBook
{
  /// <summary>
  /// Shows notes in notebook.
  /// </summary>
  public class ShowNotesCommand : Command
  {
    private NoteBookConsoleView noteBookConsoleView;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="noteBookConsoleView">Instance of NoteBookConsoleView.</param>
    public ShowNotesCommand(NoteBookConsoleView noteBookConsoleView)
    {
      this.noteBookConsoleView = noteBookConsoleView;
;     
    }

    /// <summary>
    /// Executes command.
    /// </summary>
    public void Execute()
    {
      Console.WriteLine(noteBookConsoleView.Print());
    }
  }
}
