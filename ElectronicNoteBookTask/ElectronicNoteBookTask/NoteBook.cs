using System;
using System.Text;
using System.Collections.Generic;

namespace ElectronicNoteBookTask
{
    /// <summary>
    /// Class contains the information about  NoteBook 
    /// (Title - the title of notebook and Date - the date of creation)
    /// and standart methods for using the notebook.
    /// </summary>
    public class NoteBook
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public List<Note> noteList = new List<Note>();

        /// <summary>
        /// This is the standart constructor.
        /// </summary>
        public NoteBook()
        {
        }

        /// <summary>
        /// Create notebook with transferred parameters.
        /// </summary>
        /// <param name="title">This is the title of Note</param>
        /// <param name="dateTime">This is the date of creating of Note</param>
        public NoteBook(string title)
        {
            Title = title;
            Date = DateTime.Now;
        }

        /// <summary>
        /// Ovverride method returns the string with title and date combination of NoteBook.
        /// </summary>
        /// <returns>Returns the string with title and date</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Title: ").Append(Title);
            stringBuilder.Append("\nDate ").Append(Date.ToString());
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Oveeride method compares two NoteBook-objects by fields(title and date)
        /// and returns the result of comparison.
        /// Check for null values and compare run-time types.
        /// </summary>
        /// <param name="obj">The second object for comparison</param>
        /// <returns>Returns true if Note-objects are equal, and false - if aren't equal</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            NoteBook note = (NoteBook)obj;
            return Title == note.Title && Date.Equals(note.Date);
        }

        /// <summary>
        /// Override method returns hashcode of NoteBook, 
        /// which is calculated as the sum of hashcodes of fields.
        /// </summary>
        /// <returns>Return int value of note hashcode</returns>
        public override int GetHashCode()
        {
            return Title.GetHashCode() + Date.GetHashCode();
        }
    }
}
