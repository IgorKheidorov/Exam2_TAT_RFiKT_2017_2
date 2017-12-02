using System;

namespace ElectronicNotebook
{
    /// <summary>
    /// Class-command for finding node by context.
    /// </summary>
    public class FindByContextCommand: ICommand
    {
        NoteBookReceiver receiver;
        String str;
        public FindByContextCommand(NoteBookReceiver rec, string str)
        {
            receiver = rec;
            this.str = str;
        }
        /// <summary>
        /// Overrided Execute method for FindByContextCommand.
        /// </summary>
        public void Execute()
        {
            new NoteBookConsoleView().Print(receiver.FindNoteByContent(str));
        }
    }
}
