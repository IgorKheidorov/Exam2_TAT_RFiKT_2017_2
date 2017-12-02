namespace NoteBookTask
{
    /// <summary>
    /// Creates notebook
    /// </summary>
    public class CreateNoteBook : ICommand
    {
        NoteBookProvider receiver;

        /// <summary>
        /// Constuctor of class
        /// </summary>
        /// <param name="receiver">
        /// used by command pattern
        /// </param>
        public CreateNoteBook(NoteBookProvider receiver)
        {
            this.receiver = receiver;
        }

        /// <summary>
        /// Create notebook
        /// </summary>
        public void Execute()
        {
            receiver.CreateNoteBook();
        }
    }
}