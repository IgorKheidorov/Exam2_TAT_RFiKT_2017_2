using System;

namespace ElectronicNotebook
{
    public class AddNotesCommand: ICommand
    {
        NoteBookReceiver receiver;
        Note note;
        public AddNotesCommand(NoteBookReceiver rec, Note note)
        {
            receiver = rec;
            this.note = note;
        }
        /// <summary>
        /// Overrided Execute method for AddNotesCommand.
        /// </summary>
        public void Execute()
        {
           receiver.AddNewNote(note);
        }
    }
}
