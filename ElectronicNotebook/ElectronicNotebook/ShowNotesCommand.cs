using System;

namespace ElectronicNotebook
{
    /// <summary>
    /// Class-command shows all the notes.
    /// </summary>
    public class ShowNotesCommand: ICommand
    {
        NoteBookReceiver receiver;
        public ShowNotesCommand(NoteBookReceiver rec)
        {
            receiver = rec;
        }
        /// <summary>
        /// Overrided Execute method for ShowNotesCommand.
        /// </summary>
        public void Execute()
        {
            new NoteBookConsoleView().Print(receiver.ShowNoteBookNotes());
        }
    }
}
