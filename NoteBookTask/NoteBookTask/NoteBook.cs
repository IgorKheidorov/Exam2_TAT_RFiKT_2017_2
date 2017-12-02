using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBookTask
{
    /// <summary>
    /// NoteBook class
    /// </summary>
    public class NoteBook
    {
        public List<Note> Notes { get; set; }
        public string NoteBookName { get; set; }
        public DateTime TimeOfNoteBookCreating { get; set; }
        
        /// <summary>
        /// Constuctor without parameters
        /// </summary>
        public NoteBook()
        {
            Notes = new List<Note>();
            NoteBookName = "";
            TimeOfNoteBookCreating = DateTime.UtcNow;
        }

        /// <summary>
        /// Constuctor with name
        /// </summary>
        /// <param name="name">
        /// Notebook name
        /// </param>
        public NoteBook(string name)
        {
            Notes = new List<Note>();
            NoteBookName = name;
            TimeOfNoteBookCreating = DateTime.UtcNow;
        }

        /// <summary>
        /// Compares two notebooks
        /// </summary>
        /// <param name="obj">
        /// Redused to NoteBook type
        /// </param>
        /// <returns>
        /// true if equals or false if not
        /// </returns>
        public override bool Equals(object obj)
        {
            bool areEquals;
            if (obj == null)
            {
                areEquals = false;
            }

            NoteBook book = obj as NoteBook;
            if (book as NoteBook == null)
            {
                areEquals = false;
            }
            areEquals = book.TimeOfNoteBookCreating == this.TimeOfNoteBookCreating 
                        && book.NoteBookName == this.NoteBookName
                        && book.Notes == book.Notes;

            return areEquals;
        }
        
        /// <summary>
        /// Get hash code
        /// </summary>
        /// <returns>
        /// hash code
        /// </returns>
        public override int GetHashCode()
        {
            return (int)(this.TimeOfNoteBookCreating - new DateTime(1900, 1, 1)).TotalDays + 2;
        }

        /// <summary>
        /// convert notebook to string
        /// </summary>
        /// <returns>
        /// notebook in string format
        /// </returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(NoteBookName + '\n');
            builder.Append(TimeOfNoteBookCreating.ToString() + '\n');

            foreach(var note in Notes)
            {
                builder.Append(note.ToString());
            }

            string information = builder.ToString();
            return information;
        }
    }
}