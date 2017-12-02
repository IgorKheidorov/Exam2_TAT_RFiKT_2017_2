using System;

namespace ElectronicNotebook
{
    /// <summary>
    /// Class-command for finding node by context.
    /// </summary>
    public class FindByDateCommand: ICommand 
    {
        NoteBookReceiver receiver;
        DateTimeOffset date;
        public FindByDateCommand(NoteBookReceiver rec, DateTimeOffset date)
        {
            receiver = rec;
            this.date = date;
        }
        /// <summary>
        /// Overrided Execute method for FindByDateCommand.
        /// </summary>
        public void Execute()
        {
            new NoteBookConsoleView().Print(receiver.FindNoteByDate(date));
        }
    }
}
