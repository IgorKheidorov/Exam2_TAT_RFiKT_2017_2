using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookTask
{
    public class NoteBookProvider
    {
        private static NoteBook notebook;

        public NoteBook CreateNoteBook()
        {
            notebook = new NoteBook();

            return notebook;
        }

        public void AddNote(Note note)
        {
            notebook.Notes.Add(note);
        }

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

        public void DisplayNotes(DateTime data)
        {
            Console.WriteLine(notebook.NoteBookName);
            Console.WriteLine(notebook.TimeOfNoteBookCreating);

            NoteBookConsoleView display = new NoteBookConsoleView();
            display.Print(notebook);
        }

        public void WriteNoteBookToFile()
        {
            using (StreamWriter writerToFile = new StreamWriter("Notebook.txt"))
            {
                writerToFile.Write(notebook.ToString());
            }
        }

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
            Note note = new Note();
            if (count == 1)
            {
                note.Name = line;
            }
            else if (count == 2)
            {
                note.Text = line;
            }
            else if (count == 0)
            {
                note.TimeOfCreating = DateTime.Parse(line);
            }

            notebook.Notes.Add(note);
        }
    }
}