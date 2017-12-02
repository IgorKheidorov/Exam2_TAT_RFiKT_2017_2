namespace NoteBookTask
{
    /// <summary>
    /// Realiced invokers work from command pattern
    /// </summary>
    public class WorkerWithNoteBook
    {
        private ICommand command;

        /// <summary>
        /// Set command
        /// </summary>
        /// <param name="command">
        /// Command for work
        /// </param>
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        /// <summary>
        /// Start working
        /// </summary>
        public void Run()
        {
            command.Execute();
        }
    }
}