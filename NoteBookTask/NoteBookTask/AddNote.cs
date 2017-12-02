namespace NoteBookTask
{
    /// <summary>
    /// Adds note.
    /// </summary>
    public class AddNote : ICommand
    {
        private NoteBookProvider receiver;
        public Note Note { get; set; }

        /// <summary>
        /// Constuctor of class.
        /// </summary>
        /// <param name="receiver">
        /// used by command pattern
        /// </param>
        /// <param name="note">
        /// added note
        /// </param>
        public AddNote(NoteBookProvider receiver, Note note)
        {
            this.receiver = receiver;
            this.Note = note;
        }

        /// <summary>
        /// Add note.
        /// </summary>
        public void Execute()
        {
            receiver.AddNote(Note);
        }
    }
}