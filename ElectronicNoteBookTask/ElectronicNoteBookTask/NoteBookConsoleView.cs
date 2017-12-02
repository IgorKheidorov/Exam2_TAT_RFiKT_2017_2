using System;
using System.Collections.Generic;

namespace ElectronicNoteBookTask
{
    /// <summary>
    /// Class contains methods which allow to output to the console data 
    /// about one note, data about several notes or the entire NoteBook
    /// </summary>
    public class NoteBookConsoleView
    {
        /// <summary>
        /// Method output data about one note to the console.
        /// </summary>
        /// <param name="note">One note is used for outputting</param>
        public void Print(Note note)
        {
            Console.WriteLine(note.ToString());
        }

        /// <summary>
        /// Method output data about several notes to the console.
        /// Params is a keyword, that takes a variable number of arguments.
        /// </summary>
        /// <param name="notes">Variable number of notes</param>
        public void Print(params Note[] notes)
        {
            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine(notes[i].ToString());
            }
        }

        /// <summary>
        /// Method output data about all notes of notebook to the console.
        /// </summary>
        /// <param name="noteList">noteList is the all notes of notebook</param>
        public void Print(List<Note> noteList)
        {
            foreach (Note note in noteList)
            {
                Console.WriteLine(note.ToString());
            }
        }
    }
}
