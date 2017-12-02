namespace NoteBookTask
{
    /// <summary>
    /// Finds note by context
    /// </summary>
    public class FindNoteByContext : ICommand
    {
        private NoteBookProvider receiver;
        public string Text { get; set; }
        public Note FindedNote { get; set; }

        /// <summary>
        /// Constuctor of class
        /// </summary>
        /// <param name="receiver">
        /// used by command pattern
        /// </param>
        /// <param name="text">
        /// context to searching note
        /// </param>
        public FindNoteByContext(NoteBookProvider receiver, string text)
        {
            this.receiver = receiver;
            this.Text = text;
        }

        /// <summary>
        /// Find note by context
        /// </summary>
        public void Execute()
        {
            FindedNote = receiver.FindNoteByContext(Text);
        }
    }
}