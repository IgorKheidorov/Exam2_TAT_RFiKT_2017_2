using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NoteBookProject
{
    /// <summary>
    /// Is used to store notes
    /// </summary>
    public class NoteBook
    {
        private List<Note> notes;
        private string[] separators = { "\\r\\n" };
        /// <summary>
        /// Initialize list of notes
        /// </summary>
        public NoteBook()
        {
            notes = new List<Note>();
        }
        /// <summary>
        /// add new note to notes list
        /// </summary>
        public void AddNewNote()
        {
            string title, content;
            Console.Write("Enter notes title: ");
            title = Console.ReadLine();
            Console.Write("Enter notes content: ");
            content = Console.ReadLine();
            notes.Add(new Note(title, content));
        }
        /// <summary>
        /// Show note data, if it exist
        /// </summary>
        /// <param name="content">parameter for finding</param>
        public void ShowNoteByContent(string content)
        {
            foreach ( var note in notes )
            {
                if ( note.Content == content )
                {
                    Console.WriteLine("Title: {0}", note.Title);
                    Console.WriteLine("Creating time: {0}", note.CreatingTime);
                }
            }
        }

        public void ShowNoteByCreatingTime(DateTime creatingTime)
        {
            foreach ( var note in notes )
            {
                if ( note.CreatingTime == creatingTime )
                {
                    Console.WriteLine("Title: {0}", note.Title);
                    Console.WriteLine("Content time: {0}", note.Content);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var note in notes)
            {
                builder.Append(note);
                builder.AppendLine();
            }
            return builder.ToString();
        }

        public void ShowAllNotes()
        {
            Console.Write(ToString());
        }

        public void WriteNotesToFile(string path)
        {
            StreamWriter writer;
            using ( writer = new StreamWriter(path,true) )
            {
                writer.WriteLine(ToString());
            }
        }

        private Note ParseFromString(string data)
        {         
            string[] infoLines = data.Split(separators, StringSplitOptions.None);
            Note note = new Note(infoLines[0], infoLines[1], DateTime.Parse(infoLines[2]));
            return note;
        }

        public void ReadFromFile(string path)
        {
            notes.Clear();
            StreamReader reader;
            StringBuilder builder = new StringBuilder();
            string line;
            using ( reader = new StreamReader(path) )
            {
                line = reader.ReadLine();
                
            }
        }
    }
}
