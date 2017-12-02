using System;
using System.IO;
using System.Linq;

namespace NoteBookTask
{
    //reseiver
    public class NoteBookProvider
    {
        private static NoteBook notebook;
        
        /// <summary>
        /// Create notebook
        /// </summary>
        /// <returns>
        /// created notebook
        /// </returns>
        public NoteBook CreateNoteBook()
        {
            notebook = new NoteBook();

            return notebook;
        }

        /// <summary>
        /// Add note
        /// </summary>
        /// <param name="note">
        /// added note
        /// </param>
        public void AddNote(Note note)
        {
            notebook.Notes.Add(note);
        }

        /// <summary>
        /// Find note by context
        /// </summary>
        /// <param name="text">
        /// Context to searching note
        /// </param>
        /// <returns>
        /// Node if finded, Null if not
        /// </returns>
        public Note FindNoteByContext(string text)
        {
            Note findNote = null;
            foreach (var note in notebook.Notes)
            {
                if (note.Text.Equals(text))
                {
                    findNote = note;
                    break;
                }
            }

            return findNote;
        }

        /// <summary>
        /// Find note by creating data
        /// </summary>
        /// <param name="data">
        /// creating data
        /// </param>
        /// <returns>
        /// Node if finded, Null if not
        /// </returns>
        public Note FindNoteByCreatingData(DateTime data)
        {
            Note findNote = null;
            foreach (var note in notebook.Notes)
            {
                if (note.TimeOfCreating.Equals(data))
                {
                    findNote = note;
                    break;
                }
            }

            return findNote;
        }

        /// <summary>
        /// Display full notebook
        /// </summary>
        public void DisplayNotes()
        {
            Console.WriteLine(notebook.NoteBookName);
            Console.WriteLine(notebook.TimeOfNoteBookCreating);

            NoteBookConsoleView display = new NoteBookConsoleView();
            display.Print(notebook);
        }

        /// <summary>
        /// Write notebook to file
        /// </summary>
        public void WriteNoteBookToFile()
        {
            using (StreamWriter writerToFile = new StreamWriter("Notebook.txt"))
            {
                writerToFile.Write(notebook.ToString());
            }
        }

        /// <summary>
        /// Read notebook from file
        /// </summary>
        public void ReadNoteBookFromFile()
        {
            using (StreamReader reader = new StreamReader("Notebook.txt"))
            {
                notebook = new NoteBook();
                string line;
                int count = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (count == 0)
                    {
                        notebook.NoteBookName = line;
                    }
                    else if (count == 1)
                    {
                        notebook.TimeOfNoteBookCreating = DateTime.Parse(line);
                    }
                    else
                    {
                        NoteBookProvider noteReader = new NoteBookProvider();
                        noteReader.ReadNote(line, count - 1);
                    }
                    count++;
                }
            }
        }
        
        private void ReadNote(string line, int count)
        {
            count %= 3;
            Note note;
            if (count == 1)
            {
                note = new Note(line);
            }
            else if (count == 2)
            {
                note = notebook.Notes.Last();
                note.Text = line;
            }
            else if (count == 0)
            {
                note = notebook.Notes.Last();
                note.TimeOfCreating = DateTime.Parse(line);
            }
        }
    }
}