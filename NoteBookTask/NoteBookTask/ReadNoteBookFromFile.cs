namespace NoteBookTask
{
    /// <summary>
    /// Reads notebook from file.
    /// </summary>
    class ReadNoteBookFromFile : ICommand
    {
        private NoteBookProvider receiver;

        /// <summary>
        /// Constuctor of class.
        /// </summary>
        /// <param name="receiver">
        /// used by command pattern
        /// </param>
        public ReadNoteBookFromFile(NoteBookProvider receiver)
        {
            this.receiver = receiver;
        }

        /// <summary>
        /// Read notebook from file.
        /// </summary>
        public void Execute()
        {
            receiver.ReadNoteBookFromFile();
        }
    }
}