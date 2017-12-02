namespace NoteBookProject
{
    /// <summary>
    /// The command to call the receiver to add new note to the notebook
    /// </summary>
    public class AddNewNoteCommand : ICommand
    {
        private NoteBookProvider receiver;
        /// <summary>
        /// add a receiver
        /// </summary>
        public AddNewNoteCommand()
        {
            receiver = NoteBookProvider.GetProvider();
        }
        /// <summary>
        /// call receivers desired method
        /// </summary>
        public void Execute()
        {
            receiver.AddNewNote();
        }
    }
}
