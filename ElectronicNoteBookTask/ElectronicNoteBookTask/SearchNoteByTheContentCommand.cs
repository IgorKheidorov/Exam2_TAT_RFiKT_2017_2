using System;
namespace ElectronicNoteBookTask
{
    /// <summary>
    ///  Class of specific command.
    /// A reference to the NoteBookProvider is stored 
    /// which the command will redirect the main job to NoteBookProvider.
    /// </summary>
    public class SearchNoteByTheContentCommand: ICommand
    {
        private NoteBookProvider noteBookProvider;
        private string content;
        private NoteBook noteBook;
        private Note note;

        /// <summary>
        /// Constructor assigns the value to the fields.
        /// </summary>
        /// <param name="provider">Field provider gets the value of parameter provider</param>
        /// <param name="noteBook">Field noteBook gets the value of parameter notebook</param>
        /// <param name="content">Field notegets the value of parameter content</param>
        public SearchNoteByTheContentCommand(NoteBookProvider provider, NoteBook noteBook, string content)
        {
            noteBookProvider = provider;
            this.noteBook = noteBook;
            this.content = content;
        }

        /// <summary>
        /// Method evoke for executing a specific method which searches the note by content
        /// and print into the console.
        /// </summary>
        public void Execute()
        {
            note = noteBookProvider.SearchNoteByTheContent(noteBook, content);
            NoteBookConsoleView noteBookConsoleView = new NoteBookConsoleView();
            noteBookConsoleView.Print(note);
        }
    }
}
