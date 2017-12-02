using System;

namespace ElectronicNotebook
{
    /// <summary>
    /// Gets elements for testing..
    /// </summary>
    public class ValueReader: IProvidable
    {
        /// Gets note's value;
        /// </summary>
        /// <returns>Note</returns>
        public Note GetNote()
        {
            Note note = new Note();
            note.Title = "bla";
            note.Content = "bla";
            return note;
        }
        /// <summary>
        /// Gets notebook's value.
        /// </summary>
        /// <returns>NoteBook</returns>
        public NoteBook GetNoteBook()
        {
            NoteBook notebook;
            notebook = new NoteBook("bla");
            return notebook;
        }
    }
}
