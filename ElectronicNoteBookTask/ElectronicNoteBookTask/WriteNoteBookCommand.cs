namespace ElectronicNoteBookTask
{
    public class WriteNoteBookCommand
    {
        /// <summary>
        /// Class of specific command.
        /// A reference to the NoteBookProvider is stored 
        /// which the command will redirect the main job to NoteBookProvider.
        /// </summary>
        public class CreateNoteBookCommand : ICommand
        {
            private NoteBookProvider noteBookProvider;
            private NoteBook noteBook;


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
            /// Method evoke for executing a specific method which write Notebook.
            /// </summary>
            public void Execute()
            {
                noteBookProvider.WriteNoteBookInFile(noteBook);
            }
        }
    }
}
