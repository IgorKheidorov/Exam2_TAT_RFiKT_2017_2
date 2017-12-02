using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookSaturday
{
    /// <summary>
    /// Class for 
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Information field contains record.
        /// </summary>
        public string record { get; set; }
        /// <summary>
        /// Creating note time.
        /// </summary>
        public DateTime creatingTime { get; set; }
        /// <summary>
        /// Title of note.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Compare two notes.
        /// </summary>
        /// <param name="note"> Note to compare. </param>
        /// <returns> True if equals. </returns>
        public bool Equals(Note note)
        {
            if ( note == null || creatingTime != note.creatingTime)
            {
                return false;
            }

            if (record == null && note.record == null && title == null && note.title == null)
            {
                return true;
            }
            else
            {
                if (record == null || note.record == null)
                {
                    return title == note.title;
                }
                if (title == null || note.title == null)
                {
                    return record == note.record;
                }
                return record.Equals(note.record) && title.Equals(note.title);
            }
        }

        /// <summary>
        /// Returns creating time if another fields empty.
        /// </summary>
        /// <returns> </returns>
        public override string ToString()
        {
            return title == String.Empty ? 
                (record == String.Empty ? creatingTime.ToString() : record + "\n" + creatingTime.ToString()) : 
                (title + "\n" + (record == String.Empty ? creatingTime.ToString() : record + "\n" + creatingTime.ToString()));
        }

        /// <summary>
        /// Returns note hash code.
        /// </summary>
        /// <returns> Combination of fields hash code. </returns>
        public override int GetHashCode()
        {
            if (record == null && title == null)
            {
                return creatingTime.GetHashCode();
            }
            if (record == null && title != null)
            {
                return title.GetHashCode() + creatingTime.GetHashCode();
            }
            if (record != null && title == null)
            {
                return record.GetHashCode() + creatingTime.GetHashCode();
            }
            return record.GetHashCode() + title.GetHashCode() + creatingTime.GetHashCode();
        }
    }
}
