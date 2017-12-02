using System;

namespace ElectronicNotebook
{
    /// <summary>
    /// Interface represents the command.
    /// Includes method Execute that does actions.
    /// Method Undo cancels the action.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Method for executing commands.
        /// </summary>
        void Execute();
    }
}
