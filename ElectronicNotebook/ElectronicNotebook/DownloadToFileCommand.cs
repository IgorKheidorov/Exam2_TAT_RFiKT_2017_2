using System;

namespace ElectronicNotebook
{
    /// <summary>
    /// Download notebook from the file.
    /// </summary>
    public class DownloadToFileCommand: ICommand
    {
        NoteBookReceiver receiver;
        string str;
        public DownloadToFileCommand(NoteBookReceiver rec, string str)
        {
            receiver = rec;
            this.str = str;
        }
        /// <summary>
        /// Overrided Execute method for DownloadToFileCommand.
        /// </summary>
        public void Execute()
        {
            receiver.DownloadNotebookFromFile(str);
        }
    }
}
