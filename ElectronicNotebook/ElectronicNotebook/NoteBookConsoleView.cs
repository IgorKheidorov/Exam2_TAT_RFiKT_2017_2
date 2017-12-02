using System;
using System.Text;

namespace ElectronicNotebook
{
    /// <summary>
    /// Class has ability to output notes.
    /// </summary>
    public class NoteBookConsoleView
    {
        /// <summary>
        /// Prints notes to the console.
        /// </summary>
        /// <param name="notes">List of notes.</param>
        public void Print(params Note[] notes)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < notes.Length; i++)
            {
                sb.AppendLine(notes[i].ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}