using System;

namespace NoteBookProject
{
    /// <summary>
    /// The command to call the receiver to search for notes by creation date
    /// </summary>
    public class FindNoteByCreatingTimeCommand : ICommand
    {
        private NoteBookProvider receiver;
        /// <summary>
        /// adds a receiver
        /// </summary>
        public FindNoteByCreatingTimeCommand()
        {
            receiver = NoteBookProvider.GetProvider();
        }
        /// <summary>
        /// call receivers desired method
        /// </summary>
        public void Execute()
        {
            Console.Write("Enter date: ");
            receiver.ShowNoteByCreatingTime(DateTime.Parse(Console.ReadLine()));
        }
    }
}
