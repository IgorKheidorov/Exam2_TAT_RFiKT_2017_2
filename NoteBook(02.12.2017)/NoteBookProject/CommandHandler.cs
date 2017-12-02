using System;
using System.Collections.Generic;

namespace NoteBookProject
{
    /// <summary>
    /// Is a set of commands with their keys
    /// </summary>
    public class CommandHandler
    {
        /// <summary>
        /// Stores dictionary with command keys and their objects
        /// </summary>
        public Dictionary<string, ICommand> Commands
        {
            get;private set;
        }
        /// <summary>
        /// Execute dictionary initialize method
        /// </summary>
        public CommandHandler()
        {
            InitializeDictionary();
        }
        /// <summary>
        /// add commands to the dictionary with keys and commands objects
        /// </summary>
        private void InitializeDictionary()
        {
            Commands = new Dictionary<string, ICommand>();
            Commands["find by content"] = new FindNoteByContentCommand();
            Commands["find by date"] = new FindNoteByCreatingTimeCommand();
            Commands["add note"] = new AddNewNoteCommand();
            Commands["show all"] = new ShowAllNotesCommand();
            Commands["write to file"] = new WriteNotesToFileCommand();
        }
        /// <summary>
        /// Return command, if command key key corresponds to one of the commands
        /// Throw KeyNotFoundExcepton, if command with such key don't exist
        /// </summary>
        /// <param name="commandKey">command key for finding</param>
        /// <returns>finded command by key</returns>
        public ICommand GetCommand(string commandKey)
        {
            return Commands[commandKey];
        }
    }
}
