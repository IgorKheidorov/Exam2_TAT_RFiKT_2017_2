namespace ElectronicNoteBookTask
{
    /// <summary>
    /// Class of specific command.
    /// A reference to the NoteBookProvider is stored 
    /// which the command will redirect the main job to NoteBookProvider.
    /// </summary>
    public class CreateNoteBookCommand: ICommand
    {
        private NoteBookProvider noteBookProvider;
        public NoteBook noteBook;

        /// <summary>
        /// Constructor assigns the value to the receiver - noteBookProvider.
        /// </summary>
        /// <param name="provider">Value are used for assegning to the receiver</param>
        /// <param name="noteBook">Value are used for assegning to the noteBook</param>
        public CreateNoteBookCommand(NoteBookProvider provider, NoteBook noteBook)
        {
            noteBookProvider = provider;
            this.noteBook = noteBook;
        }

        /// <summary>
        /// Method evoke for executing a specific method which create notebook.
        /// </summary>
        public void Execute()
        {
            noteBook = noteBookProvider.CreateNewNoteBook(noteBook);
        }
    }
}
