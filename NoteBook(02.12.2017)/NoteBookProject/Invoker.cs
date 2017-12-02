namespace NoteBookProject
{
    /// <summary>
    /// acts as a requester
    /// </summary>
    public class Invoker
    {
        private ICommand command;
        /// <summary>
        /// Calls command execute method
        /// </summary>
        public void Run()
        {
            command.Execute();
        }
        /// <summary>
        /// set commnad
        /// </summary>
        /// <param name="command">command for execute</param>
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
    }
}
