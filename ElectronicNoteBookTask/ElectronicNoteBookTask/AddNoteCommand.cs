namespace ElectronicNoteBookTask
{
    /// <summary>
    /// Class of specific command.
    /// A reference to the NoteBookProvider is stored 
    /// which the command will redirect the main job to NoteBookProvider.
    /// </summary>
    public class AddNoteCommand: ICommand
    {
        private NoteBookProvider noteBookProvider;
        private NoteBook noteBook;
        private Note note;

        /// <summary>
        /// Constructor assigns the value to the fields.
        /// </summary>
        /// <param name="provider">Field provider gets the value of parameter provider</param>
        /// <param name="noteBook">Field noteBook gets the value of parameter notebook</param>
        /// <param name="note">Field notegets the value of parameter note</param>
        public AddNoteCommand(NoteBookProvider provider, NoteBook noteBook, Note note)
        {
            noteBookProvider = provider;
            this.noteBook = noteBook;
            this.note = note;
        }

        /// <summary>
        /// Method evoke for executing a specific method which add note to notebook.
        /// </summary>
        public void Execute()
        {
           noteBook = noteBookProvider.AddNote(noteBook, note);
        }
    }
}
