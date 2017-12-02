using System;

namespace NoteBookProject
{
    /// <summary>
    /// is the mediator to the NoteBook object, exist only one object the appropriate type
    /// </summary>
    public class NoteBookProvider
    {
        private static NoteBookProvider provider;
        /// <summary>
        /// stores the object type NoteBook, which is a mediator for it
        /// </summary>
        public NoteBook GetNoteBook
        {
            get;private set;
        }
        /// <summary>
        /// private constructor for single object
        /// </summary>
        private NoteBookProvider()
        {
            GetNoteBook = new NoteBook();
        }
        /// <summary>
        /// initialize or returns a single object of the given type
        /// </summary>
        /// <returns>return single NoteBookProvedir object</returns>
        public static NoteBookProvider GetProvider()
        {
            if ( provider == null )
            {
                provider = new NoteBookProvider();
            }
            return provider;
        }
        /// <summary>
        /// Calls a specific method of the stored NoteBook to display needed note
        /// </summary>
        /// <param name="content">content for finding</param>
        public void ShowNoteByContent(string content)
        {
            GetNoteBook.ShowNoteByContent(content);
        }
        /// <summary>
        /// Calls a specific method of the stored NoteBook to display needed note
        /// </summary>
        /// <param name="creatingTime">creating time for finding</param>
        public void ShowNoteByCreatingTime(DateTime creatingTime)
        {
            GetNoteBook.ShowNoteByCreatingTime(creatingTime);
        }
        /// <summary>
        /// Calls a specific method of the stored NoteBook to add new note
        /// </summary>
        public void AddNewNote()
        {
            GetNoteBook.AddNewNote();
        }
        /// <summary>
        /// Calls a specific method of the stored NoteBook to show all notebook
        /// </summary>
        public void ShowAllNotes()
        {
            GetNoteBook.ShowAllNotes();
        }
        /// <summary>
        /// Calls a specific method of the stored NoteBook to write notes to the file
        /// </summary>
        /// <param name="path">file path</param>
        public void WriteNotesToFile(string path)
        {
            GetNoteBook.WriteNotesToFile(path);
        }
    }
}
