namespace NoteBookTask
{
    /// <summary>
    /// Used by command pattern
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Execute somethink
        /// </summary>
        void Execute();

        /// <summary>
        /// Undo somethink
        /// Not yet realised
        /// </summary>
        void Undo();
    }
}