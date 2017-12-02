using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookTask
{
    public class NoteBook
    {
        public List<Note> Notes { get; set; }
        public string NoteBookName { get; set; }
        public DateTime TimeOfNoteBookCreating { get; set; }

        public NoteBook()
        {
            Notes = new List<Note>();
            NoteBookName = "";
            TimeOfNoteBookCreating = DateTime.UtcNow;
        }

        public NoteBook(string name)
        {
            Notes = new List<Note>();
            NoteBookName = name;
            TimeOfNoteBookCreating = DateTime.UtcNow;
        }

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

        public override int GetHashCode()
        {
            return (int)(this.TimeOfNoteBookCreating - new DateTime(1900, 1, 1)).TotalDays + 2;
        }

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