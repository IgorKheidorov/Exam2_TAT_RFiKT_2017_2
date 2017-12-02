using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookTask
{
    public class NoteBookConsoleView
    {
        public void Print(Note note)
        {
            Console.WriteLine(note);
        }

        public void Print(NoteBook notes, int numberOfPrintNotes)
        {
            for (int i = 0; i < numberOfPrintNotes; i++)
            {
                Console.WriteLine(notes.Notes[i]);
            }
        }

        public void Print(NoteBook notes)
        {
            foreach(var note in notes.Notes)
            {
                Console.WriteLine(note);
            }
        }
    }
}