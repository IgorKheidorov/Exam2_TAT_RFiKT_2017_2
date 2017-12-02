using System;
using System.Text;
using System.IO;

namespace ElectronicNotebook
{
    /// <summary>
    /// Class receiver of the command.
    /// Defines the actions that should be executed as a result of the request.
    /// </summary>
    public class NoteBookReceiver
    {
        public const string FOUND_NOTE = "Found notes are: ";
        public const string EMPTY_NOTEBOOK = "Notebook is empty";
        public NoteBook notebook;
        public IProvidable NotesProvidable { get; set; }
        public NoteBookReceiver()
        {}
        public NoteBookReceiver(IProvidable notesProvidable)
        {
            NotesProvidable = notesProvidable;
        }
        /// <summary>
        /// Method that creates a new Notebook.
        /// </summary>
        public NoteBook CreateNewNoteBook()
        {
            notebook = NotesProvidable.GetNoteBook();
            return notebook;
        }
        /// <summary>
        /// Add new Note to the NoteBook.
        /// </summary>
        public void AddNewNote(Note note)
        {
            note = NotesProvidable.GetNote();
            notebook.Notes.Add(note);
        }
        /// <summary>
        /// Method finds note by its content.
        /// </summary>
        /// <param name="content">String by which finds note</param>
        /// <returns>Found note</returns>
        public Note FindNoteByContent (string content)
        {
            foreach (var notes in notebook.Notes)
            {
                if (notes.Content.Equals(content))
                {
                    return notes;
                }
            }
            return null;
        }
        /// <summary>
        /// Finds note by its data
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public Note FindNoteByDate(DateTimeOffset date)
        {
            foreach (var notes in notebook.Notes)
            {
                if (notes.Date.Equals(date))
                {
                    return notes;
                }
            }
            return null;
        }
        /// <summary>
        /// Shows all notes in the notebook.
        /// </summary>
        public Note[] ShowNoteBookNotes()
        {
            Note[] notes = new Note[]{};
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < notebook.Notes.Count; i++ )
            {
                notes[i] = notebook.Notes[i];
            }
            return notes;
        }
        /// <summary>
        /// Writes notebook to the file.
        /// </summary>
        public void WriteNoteBookToFile()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\WriteLines.txt"))
            {
                foreach (var note in notebook.Notes)
                {
                    outputFile.WriteLine(note.ToString());
                }     
            }
        }
        /// <summary>
        /// Downloads notebook from the file.
        /// Method in development.
        /// </summary>
        /// <param name="path">Path of the file</param>
        public void DownloadNotebookFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    notebook.Title = line;
                }
            }
        }
    }
}
