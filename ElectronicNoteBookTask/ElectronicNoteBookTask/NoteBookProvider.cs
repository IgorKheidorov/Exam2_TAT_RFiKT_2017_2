using System;
using System.IO;

namespace ElectronicNoteBookTask
{
    /// <summary>
    /// Class contains all methods of all business logic methods of the program 
    /// and defines the actions to be performed as a result of the query.
    /// </summary>
    public class NoteBookProvider
    {
        private const string  TITLE_OF_NOTEBOOK = "Enter the title of NoteBook";

        /// <summary>
        /// Method creates new notebook.
        /// </summary>
        /// <param name="noteBook">The notebook is used for creating new object</param>
        /// <returns>Returns created notebook</returns>
        public NoteBook CreateNewNoteBook(NoteBook noteBook)
        {
            Console.WriteLine(TITLE_OF_NOTEBOOK);
            string title = Console.ReadLine();
            noteBook.Title = title;
            return noteBook;
        }

        /// <summary>
        /// Method add the note to the Notebook.
        /// </summary>
        /// <param name="notebook">the notebook is used for adding the note</param>
        /// <param name="note">The note is used for adding to notebook</param>
        public NoteBook AddNote(NoteBook noteBook, Note note)
        {
            noteBook.noteList.Add(note);
            return noteBook;
        }

        /// <summary>
        /// Method search the note by the content.
        /// </summary>
        /// <param name="noteBook">The notebook is used for searching the note</param>
        /// <param name="content">The content is parameter for searching to the list of notes in notebook</param>
        /// <returns></returns>
        public Note SearchNoteByTheContent(NoteBook noteBook, string content)
        {
            foreach(Note note in noteBook.noteList)
            {
                if (content == note.Value || content == note.Title)
                {
                    return note;
                }
            }
            throw new InvalidOperationException("Note not found!");
        }

        /// <summary>
        /// Method search the note by the date.
        /// </summary>
        /// <param name="noteBook">The notebook is used for searching the note</param>
        /// <param name="date">The date is parameter for searching to the list of notes in notebook</param>
        public Note SearchNoteByTheCreatingData(NoteBook noteBook, string date)
        {
            foreach (Note note in noteBook.noteList)
            {
                if (date == note.Date.ToString())
                {
                    return note;
                }
            }
            throw new InvalidOperationException("Note not found!");
        }

        /// <summary>
        /// Method Output all notes from notebook
        /// </summary>
        /// <param name="noteBook">The notebook is used for outputting the notes from this notebook</param>
        public void DisplayNotesInBookNote(NoteBook noteBook)
        {
            NoteBookConsoleView noteBookConsoleView = new NoteBookConsoleView();
            noteBookConsoleView.Print(noteBook.noteList);
        }

        /// <summary>
        /// Method Write Notebook in File.
        /// </summary>
        public void WriteNoteBookInFile(NoteBook noteBook)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\WriteLines.txt"))
            {
                foreach (var note in noteBook.noteList)
                {
                    outputFile.WriteLine(note.ToString());
                }
            }
        }

        /// <summary>
        /// Method read Notebook from file.
        /// </summary>
        public void ReadNoteBookFromFile()
        {

        }
    }
}
