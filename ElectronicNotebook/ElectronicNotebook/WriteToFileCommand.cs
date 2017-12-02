using System;

namespace ElectronicNotebook
{
    /// <summary>
    /// Class-command writes notebook to the file.
    /// </summary>
    public class WriteToFileCommand: ICommand
    {
        NoteBookReceiver receiver;
        public WriteToFileCommand(NoteBookReceiver rec)
        {
            receiver = rec;
        }
        /// <summary>
        /// Overrided Execute method for WriteToFileCommand.
        /// </summary>
        public void Execute()
        {
            receiver.WriteNoteBookToFile();
        }
    }
}
