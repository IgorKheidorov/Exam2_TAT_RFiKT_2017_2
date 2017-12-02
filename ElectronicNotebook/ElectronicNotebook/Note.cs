using System;
using System.Text;

namespace ElectronicNotebook
{
    /// <summary>
    /// Class note. Contains note title, information and data of the creation.
    /// </summary
    public class Note
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTimeOffset Date { get; set; }
        public Note()
        {
            Date = DateTimeOffset.Now;
        }
        public Note(string title, string content)
        {
            Title = title;
            Content = content;
            Date = DateTimeOffset.Now;
        }
        /// <summary>
        /// Returns the string that represents current object.
        /// </summary>
        /// <returns>String representation of the note.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.AppendLine(Content);
            sb.AppendLine(Date.ToString());
            return sb.ToString();
        }
        /// <summary>
        /// Deteremines whether the specified Note is equal to the current Note.
        /// </summary>
        /// <param name="note">Specified Note.</param>
        /// <returns>True - notes are equal.
        /// False - aren't equal.</returns>
        public override bool Equals(Object obj)
        {
            Note note = obj as Note;
            return (this.Title.Equals(note.Title))
                && (this.Content.Equals(note.Content)
                && (this.Date.Equals(note.Date)));
        }
        ///Serves as a hash function for a particular type.
        public override int GetHashCode()
        {
            int hashcode = Title.GetHashCode() + Content.GetHashCode() + Date.GetHashCode();
            return hashcode;
        }
    }
}
