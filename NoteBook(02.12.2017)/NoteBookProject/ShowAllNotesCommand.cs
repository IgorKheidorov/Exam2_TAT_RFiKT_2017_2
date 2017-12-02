namespace NoteBookProject
{
    public class ShowAllNotesCommand : ICommand
    {
        private NoteBookProvider receiver;

        public ShowAllNotesCommand()
        {
            receiver = NoteBookProvider.GetProvider();
        }

        public void Execute()
        {
            receiver.ShowAllNotes();
        }
    }
}
