namespace NoteBookTask
{
    /// <summary>
    /// Displays notes
    /// </summary>
    class DisplayNotes : ICommand
    {
        private NoteBookProvider receiver;

        /// <summary>
        /// Constuctor of class
        /// </summary>
        /// <param name="receiver">
        /// used by command pattern
        /// </param>
        public DisplayNotes(NoteBookProvider receiver)
        {
            this.receiver = receiver;
        }

        /// <summary>
        /// Display notes
        /// </summary>
        public void Execute()
        {
            receiver.DisplayNotes();
        }
    }
}