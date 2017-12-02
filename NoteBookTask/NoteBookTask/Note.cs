using System;
using System.Text;

namespace NoteBookTask
{
    /// <summary>
    /// Note class
    /// </summary>
    public class Note
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime TimeOfCreating { get; set; }

        /// <summary>
        /// Constuctor without parameters
        /// </summary>
        public Note()
        {
            Name = "No name";
            Text = "No text";
            TimeOfCreating = DateTime.UtcNow;
        }

        /// <summary>
        /// Constuctor with name
        /// </summary>
        /// <param name="name">
        /// Note name
        /// </param>
        public Note(string name)
        {
            Name = name;
            Text = "No text";
            TimeOfCreating = DateTime.UtcNow;
        }

        /// <summary>
        /// Compares two notes
        /// </summary>
        /// <param name="obj">
        /// Redused to Note type
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

            Note note = obj as Note;
            if (note as Note == null)
            {
                areEquals = false;
            }
            areEquals = (note.TimeOfCreating == this.TimeOfCreating) 
                        && (note.Name == this.Name)
                        && (note.Text == this.Text);

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
            return (int)(this.TimeOfCreating - new DateTime(1900, 1, 1)).TotalDays + 2;
        }

        /// <summary>
        /// convert note to string
        /// </summary>
        /// <returns>
        /// note in string format
        /// </returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Name + '\n');
            builder.Append(Text + '\n');
            builder.Append(TimeOfCreating);

            string information = builder.ToString();
            return information;
        }
    }
}