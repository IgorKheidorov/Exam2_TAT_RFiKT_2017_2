using System;
using System.Text;

namespace ElectronicNoteBookTask
{
    /// <summary>
    /// Class contains the information about Note in NoteBook
    /// (Title - the title of note, Value - value which stored in note and Date - the date of creation)
    /// and standart methods for using the note.
    /// </summary>
    public class Note
    {
        public string Title { get; set; }
        public string Value { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// This is the standart constructor.
        /// </summary>
        public Note()
        {
        }

        /// <summary>
        /// Create note with transferred parameters.
        /// </summary>
        /// <param name="title">This is the title of Note</param>
        /// <param name="value">This is the value of Note</param>
        /// <param name="dateTime">This is the date of creating of Note</param>
        public Note(string title, string value)
        {
            Title = title;
            Value = value;
            Date = DateTime.Now;
        }

        /// <summary>
        /// Ovverride method returns the string of value, title and date combination of note.
        /// </summary>
        /// <returns>Returns the string with value, title and date</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Title: ").Append(Title);
            stringBuilder.Append("\nValue: ").Append(Value);
            stringBuilder.Append("\nDate ").Append(Date.ToString());
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Oveeride method compares two Note-objects by fields(title, value and date)
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
            Note note = (Note)obj;
            return Title == note.Title && Value == note.Value && Date.Equals(note.Date);
        }

        /// <summary>
        /// Override method returns hashcode of Note, 
        /// which is calculated as the sum of hashcodes of fields.
        /// </summary>
        /// <returns>Return int value of note hashcode</returns>
        public override int GetHashCode()
        {
            return Title.GetHashCode() + Value.GetHashCode() + Date.GetHashCode();
        }
    }
}
