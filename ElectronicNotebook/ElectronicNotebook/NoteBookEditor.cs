using System;

namespace ElectronicNotebook
{
    /// <summary>
    /// Initiator of the command.
    /// Calls a command to execute a specific request
    /// </summary>
    public class NoteBookEditor
    {
        ICommand command;
        /// <summary>
        /// Sets the command.
        /// </summary>
        /// <param name="com"></param>
        public void SetCommand(ICommand com)
        {
            command = com;
        }
        /// <summary>
        /// Runs seted command.
        /// </summary>
        public void Run()
        {
            command.Execute();
        }
    }
}
