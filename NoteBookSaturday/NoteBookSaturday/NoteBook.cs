using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookSaturday
{
    /// <summary>
    /// Class NoteBook contains all necessary to deal with note book.
    /// </summary>
    public class NoteBook
    {
        private string noteBookName { get; set; }
        private List<Note> notes;
        private int count { get; set; }
        private int currentPosition { get; set; }

        /// <summary>
        /// Create new noteBook.
        /// </summary>
        public NoteBook(string noteBookName)
        {
            notes = new List<Note>();
            this.noteBookName = noteBookName;
        }

        /// <summary>
        /// Add to note book record.
        /// </summary>
        /// <param name="record"> The text of record. </param>
        /// <param name="title"> By default 'Record'. </param>
        public void Add(string record, string title = "Record")
        {
            Note note = new Note();
            note.record = record;
            note.creatingTime = DateTime.Now;
            if (title.Equals("Record"))
            {
                count++;
                note.title = title + " " + count;
            }
            else
            {
                note.title = title;
            }
            notes.Add(note);
        }

        /// <summary>
        /// Returns null if list empty.
        /// </summary>
        /// <returns> Returns note on current position </returns>
        public Note GetCurrentNote()
        {
            if (notes.Count == 0)
            {
                return null;
            }
            return notes.ElementAt(currentPosition);
        }

        /// <summary>
        /// Set current position to start of notebook.
        /// </summary>
        /// <returns> Returns false if impossible to move start note. </returns>
        public bool MoveStart()
        {
            if (notes.Count == 0)
            {
                return false;
            }
            currentPosition = 0;
            return true;
        }

        /// <summary>
        /// Move current position to next note.
        /// </summary>
        /// <returns> Returns false if impossible to move next note. </returns>
        public bool MoveNext()
        {
            if (notes.Count == 0 || currentPosition == notes.Count - 1)
            {
                return false;
            }
            currentPosition++;
            return true;
        }

        /// <summary>
        /// Move current position to previouse note.
        /// </summary>
        /// <returns> Returns false if impossible to move previouse note. </returns>
        public bool MoveBack()
        {
            if (notes.Count == 0 || currentPosition == 0)
            {
                return false;
            }
            currentPosition--;
            return true;
        }

        /// <summary>
        /// Returns null if note by date not foud.
        /// </summary>
        /// <param name="date"> Date of note to find. </param>
        /// <returns> Returns note with date from param. </returns>
        public Note GetNoteByDate(DateTime date)
        {
            if (notes.Count == 0)
            {
                return null;
            }

            foreach (Note note in notes)
            {
                if (note.creatingTime.Equals(date))
                {
                    return note;
                }
            }
            return null;
        }

        /// <summary>
        /// Returns null if note by title not foud.
        /// </summary>
        /// <param name="title"> Title of note to find. </param>
        /// <returns> Returns note with title from param. </returns>
        public Note GetNoteByTitle(string title)
        {
            if (notes.Count == 0)
            {
                return null;
            }

            foreach (Note note in notes)
            {
                if (note.title.Equals(title))
                {
                    return note;
                }
            }
            return null;
        }

        /// <summary>
        /// Returns null if note by records not foud.
        /// </summary>
        /// <param name="record"> Title of note to find. </param>
        /// <returns> Returns note with title from param. </returns>
        public Note GetNoteByRecord(string record)
        {
            if (notes.Count == 0)
            {
                return null;
            }

            foreach (Note note in notes)
            {
                if (note.record.Equals(record))
                {
                    return note;
                }
            }
            return null;
        }

        /// <summary>
        /// If note book empt return 0.
        /// </summary>
        /// <returns> Returns hash code of note book. </returns>
        public override int GetHashCode()
        {
            int result = 0;
            foreach (Note note in notes)
            {
                result += note.GetHashCode();
            }
            result += noteBookName.GetHashCode();
            return result;
        }

        /// <summary>
        /// Compare two note
        /// </summary>
        /// <param name="noteBook"></param>
        /// <returns></returns>
        public bool Equals(NoteBook noteBook)
        {
            return GetHashCode() == noteBook.GetHashCode() ? true : false ;
        }

        /// <summary>
        /// Delet last added record.
        /// </summary>
        /// <returns> Returns true if record was deleted, and false if not. </returns>
        public bool DeleteLastNote()
        {
            if (notes.Count == 0)
            {
                return false;
            }
            notes.RemoveAt(notes.Count - 1);
            return true;
        }

        /// <summary>
        /// Delete note by date.
        /// </summary>
        /// <param name="date"> Date of creating note to delete. </param>
        /// <returns> Returns true if note was deleted. </returns>
        public bool DeleteNoteByDate(DateTime date)
        {
            if (notes.Count == 0)
            {
                return false;
            }

            foreach (Note note in notes)
            {
                if (note.creatingTime.Equals(date))
                {
                    notes.Remove(note);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Delete note by title.
        /// </summary>
        /// <param name="title"> Title of note to delete. </param>
        /// <returns> Returns true if note was deleted. </returns>
        public bool DeleteNoteByTitle(string title)
        {
            if (notes.Count == 0)
            {
                return false;
            }

            foreach (Note note in notes)
            {
                if (note.title.Equals(title))
                {
                    notes.Remove(note);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Delete note by record.
        /// </summary>
        /// <param name="record"> Record of note to delete. </param>
        /// <returns> Returns true if note was deleted. </returns>
        public bool DeleteNoteByRecord(string record)
        {
            if (notes.Count == 0)
            {
                return false;
            }

            foreach (Note note in notes)
            {
                if (note.record.Equals(record))
                {
                    notes.Remove(note);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Returns note book name if there is no records.
        /// </summary>
        /// <returns> Returns all notes in one string with title of note book on the top. </returns>
        public override string ToString()
        {
            if (notes.Count == 0)
            {
                return noteBookName;
            }

            string divigion = "\n-----------------------------\n";
            StringBuilder noteToString = new StringBuilder();
            noteToString.Append(noteBookName);
            noteToString.Append(divigion);
            foreach (Note note in notes)
            {
                noteToString.Append(note.ToString());
                noteToString.Append(divigion);
            }
            return noteToString.ToString();
        }
    }
}
