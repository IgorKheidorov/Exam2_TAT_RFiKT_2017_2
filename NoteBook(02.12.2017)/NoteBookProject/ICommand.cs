namespace NoteBookProject
{
    /// <summary>
    /// Interface for all commands
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Calls receivers needed method
        /// </summary>
        void Execute();
    }
}
