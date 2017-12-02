namespace ElectronicNoteBookTask
{
    /// <summary>
    /// Class of the invoker accept the finished command and run the command.
    /// </summary>
    public class Invoker
    {
        ICommand command;

        public Invoker()
        {
        }

        /// <summary>
        ///Method accepts needed command for executing and set it.
        /// </summary>
        /// <param name="command">Transfred parameter is set in the object of interface</param>
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        /// <summary>
        /// Method runs the command.
        /// </summary>
        public void Run()
        {
            command.Execute();
        }
    }
}
