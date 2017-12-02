using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookTask
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Note note = new Note();
            note.Name = "Name";
            note.Text = "This is new note";
            note.TimeOfCreating = DateTime.UtcNow;

            Console.WriteLine(note);
            Console.WriteLine(note.ToString());
        }
    }
}
