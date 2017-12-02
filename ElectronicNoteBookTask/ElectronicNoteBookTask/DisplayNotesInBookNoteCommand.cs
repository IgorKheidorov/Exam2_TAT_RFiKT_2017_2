namespace ElectronicNoteBookTask
{
    /// <summary>
    ///  Class of specific command.
    /// A reference to the NoteBookProvider is stored 
    /// which the command will redirect the main job to NoteBookProvider.
    /// </summary>
    public class DisplayNotesInBookNoteCommand
    {
        private NoteBookProvider noteBookProvider;
        private NoteBook noteBook;
        /// <summary>
        /// Constructor assigns the value to the fields.
        /// </summary>
        /// <param name="provider">Field provider gets the value of parameter provider</param>
        /// <param name="noteBook">Field noteBook gets the value of parameter notebook</param>
        public DisplayNotesInBookNoteCommand(NoteBookProvider provider, NoteBook noteBook)
        {
            noteBookProvider = provider;
            this.noteBook = noteBook;
        }
        /// <summary>
        /// Method evoke for executing a specific method for displaying the notes.
        /// </summary>
        public void Execute()
        {
            noteBookProvider.DisplayNotesInBookNote(noteBook);
        }
    }
}
