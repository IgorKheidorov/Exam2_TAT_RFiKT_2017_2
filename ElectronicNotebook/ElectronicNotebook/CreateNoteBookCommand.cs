using System;

namespace ElectronicNotebook
{
    /// <summary>
    /// Class command for creating notebook.
    /// </summary>
    public class CreateNoteBookCommand : ICommand
    {
        NoteBookReceiver receiver;
        public CreateNoteBookCommand(NoteBookReceiver rec)
        {
            receiver = rec;
        }
        /// <summary>
        /// Overrided Execute method for NoteBookProvider.
        /// </summary>
        public void Execute()
        {
            receiver.notebook = receiver.CreateNewNoteBook();
        }
    }
}
