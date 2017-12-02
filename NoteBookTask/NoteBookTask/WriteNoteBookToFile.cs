namespace NoteBookTask
{
    /// <summary>
    /// Writes notebook to file
    /// </summary>
    public class WriteNoteBookToFile : ICommand
    {
        private NoteBookProvider receiver;

        /// <summary>
        /// Constuctor of class
        /// </summary>
        /// <param name="receiver">
        /// used by command pattern
        /// </param>
        public WriteNoteBookToFile(NoteBookProvider receiver)
        {
            this.receiver = receiver;
        }

        /// <summary>
        /// Write notebook to file
        /// </summary>
        public void Execute()
        {
            receiver.WriteNoteBookToFile();
        }

        public void Undo()
        { }
    }
}