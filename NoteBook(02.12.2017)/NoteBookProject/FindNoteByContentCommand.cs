using System;
using System.Collections.Generic;
namespace NoteBookProject
{
    /// <summary>
    /// The command to call the receiver to search for notes by content
    /// </summary>
    public class FindNoteByContentCommand : ICommand
    {
        private NoteBookProvider receiver;
        /// <summary>
        /// add a receiver
        /// </summary>
        public FindNoteByContentCommand()
        {
            receiver = NoteBookProvider.GetProvider();
        }
        /// <summary>
        /// call receivers desired method
        /// </summary>
        public void Execute()
        {
            Console.Write("Enter content: ");
            receiver.ShowNoteByContent(Console.ReadLine());
        }

    }
}
