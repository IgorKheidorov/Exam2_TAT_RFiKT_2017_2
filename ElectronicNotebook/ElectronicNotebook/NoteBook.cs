using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicNotebook
{
    /// <summary>
    /// Class entity that has aggregate of notes.
    /// </summary>
    public class NoteBook
    {
        public string Title { get; set; }
        public DateTimeOffset Date { get; set; }
        public List<Note> Notes = new List<Note>();
        public NoteBook()
        {
            Date = DateTimeOffset.Now;
        }
        public NoteBook(string title)
        {
            Title = title;
            Date = DateTimeOffset.Now;
        }
        /// <summary>
        /// Returns the string that represents current object.
        /// </summary>
        /// <returns>String representation of the notebook.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.AppendLine(Date.ToString());
            foreach (var note in Notes)
            {
                sb.AppendLine(note.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// Deteremines whether the specified NoteBook is equal to the current NoteBook.
        /// </summary>
        /// <param name="notebook">Specified NoteBook.</param>
        /// <returns>True - notebooks are equal.
        /// False - aren't equal.</returns>
        public override bool Equals(Object obj)
        {
            NoteBook notebook = obj as NoteBook;
            return this.Title.Equals(notebook.Title) && this.Date.Equals(notebook.Date);
        }
        ///Serves as a hash function for a particular type.
        public override int GetHashCode()
        {
            int hashcode = Title.GetHashCode() + Date.GetHashCode();
            return hashcode;
        }
    }
}
