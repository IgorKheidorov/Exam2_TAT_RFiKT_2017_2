using System;

namespace NoteBookTask
{
    /// <summary>
    /// Console viewer for notebook
    /// </summary>
    public class NoteBookConsoleView
    {
        /// <summary>
        /// Print one note
        /// </summary>
        /// <param name="note">
        /// note for print
        /// </param>
        public void Print(Note note)
        {
            Console.WriteLine(note);
        }
        
        /// <summary>
        /// Print some notes
        /// </summary>
        /// <param name="note">
        /// notes
        /// </param>
        /// <param name="numberOfPrintNotes">
        /// number of notes for print
        /// </param>
        public void Print(NoteBook notes, int numberOfPrintNotes)
        {
            for (int i = 0; i < numberOfPrintNotes; i++)
            {
                Console.WriteLine(notes.Notes[i]);
            }
        }

        /// <summary>
        /// Print all notes
        /// </summary>
        /// <param name="notes">
        /// full notebook
        /// </param>
        public void Print(NoteBook notes)
        {
            foreach(var note in notes.Notes)
            {
                Console.WriteLine(note);
            }
        }
    }
}