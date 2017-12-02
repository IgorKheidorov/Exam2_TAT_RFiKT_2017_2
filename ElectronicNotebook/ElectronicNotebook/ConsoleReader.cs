using System;

namespace ElectronicNotebook
{
    /// <summary>
    /// Gets value from the console.
    /// </summary>
    public class ConsoleReader : IProvidable
    {
        public const string NOTEBOOK_TITLE = "Input the title of the notebook: ";
        public const string NOTE_TITLE = "Input the title of the note: ";
        public const string NOTE_CONTENT = "Input the content of the note: ";
        /// <summary>
        /// Gets note's value from the console;
        /// </summary>
        /// <returns>Note</returns>
        public Note GetNote()
        {
            Note note = new Note();
            Console.WriteLine(NOTE_TITLE);
            note.Title = Console.ReadLine();
            Console.WriteLine(NOTE_CONTENT);
            note.Content = Console.ReadLine();
            return note;
        }
        /// <summary>
        /// Gets notebook's value from the console.
        /// </summary>
        /// <returns>NoteBook</returns>
        public NoteBook GetNoteBook()
        {
            NoteBook notebook;
            Console.WriteLine(NOTEBOOK_TITLE);
            notebook = new NoteBook(Console.ReadLine());
            return notebook;
        }
    }
}
