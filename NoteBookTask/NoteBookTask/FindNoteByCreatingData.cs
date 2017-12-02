using System;

namespace NoteBookTask
{
    /// <summary>
    /// Finds note by creating data
    /// </summary>
    public class FindNoteByCreatingData : ICommand
    {
        private NoteBookProvider receiver;
        public DateTime Data { get; set; }
        public Note FindedNote { get; set; }

        /// <summary>
        /// Constuctor of class
        /// </summary>
        /// <param name="receiver">
        /// used by command pattern
        /// </param>
        /// <param name="Data">
        /// date to searching note
        /// </param>
        public FindNoteByCreatingData(NoteBookProvider receiver, DateTime Data)
        {
            this.receiver = receiver;
            this.Data = Data;
        }

        /// <summary>
        /// Find note by creating data
        /// </summary>
        public void Execute()
        {
            FindedNote = receiver.FindNoteByCreatingData(Data);
        }
    }
}