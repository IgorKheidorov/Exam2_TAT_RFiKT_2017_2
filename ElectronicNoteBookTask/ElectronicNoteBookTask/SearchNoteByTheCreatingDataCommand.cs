namespace ElectronicNoteBookTask
{
    /// <summary>
    ///  Class of specific command.
    /// A reference to the NoteBookProvider is stored 
    /// which the command will redirect the main job to NoteBookProvider.
    /// </summary>
    public class SearchNoteByTheCreatingDataCommand
    {
        private NoteBookProvider noteBookProvider;
        private string date;
        private NoteBook noteBook;
        private Note note;

        /// <summary>
        /// Constructor assigns the value to the fields.
        /// </summary>
        /// <param name="provider">Field provider gets the value of parameter provider</param>
        /// <param name="noteBook">Field noteBook gets the value of parameter notebook</param>
        /// <param name="content">Field notegets the value of parameter content</param>
        public SearchNoteByTheCreatingDataCommand(NoteBookProvider provider, NoteBook noteBook, string content)
        {
            noteBookProvider = provider;
            this.noteBook = noteBook;
            date = content;
        }

        /// <summary>
        /// Method evoke for executing a specific method which searches the note by date
        /// and print into the console.
        /// </summary>
        public void Execute()
        {
            note = noteBookProvider.SearchNoteByTheContent(noteBook, date);
            NoteBookConsoleView noteBookConsoleView = new NoteBookConsoleView();
            noteBookConsoleView.Print(note);
        }


        /// <summary>
        /// Override method returns Note in form of string. Method is using in tests.
        /// </summary>
        /// <returns>Returns string notes</returns>
        public override string ToString()
        {
            return note.ToString();
        }
    }
}
