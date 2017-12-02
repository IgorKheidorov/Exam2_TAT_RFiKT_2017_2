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
            return record.Equals(note.record) && title.Equals(note.title) && creatingTime.Equals(note.creatingTime);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns> Title,  </returns>
        public string ToStrng()
        {
            return title == String.Empty ? (record == String.Empty ? null : record) : (title + (record == String.Empty ? null : "\n" + record));
        }

        /// <summary>
        /// Returns note hash code.
        /// </summary>
        /// <returns> Combination of fields hash code. </returns>
        public override int GetHashCode()
        {
            return record.GetHashCode() + title.GetHashCode() + creatingTime.GetHashCode();
        }
    }
}
