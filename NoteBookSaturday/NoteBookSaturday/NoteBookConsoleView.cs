using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookSaturday
{
    class NoteBookConsoleView
    {
        private NoteBook noteBook {get; set; }

        public NoteBookConsoleView(NoteBook noteBook)
        {
            this.noteBook  = noteBook;
        }

        /// <summary>
        /// Print all notes from notebook.
        /// </summary>
        public void Print()
        {
            Console.WriteLine(noteBook.ToString());
        }

        /// <summary>
        /// Print on console all records that was created between start and stop dates.
        /// </summary>
        /// <param name="start"> Date print from. </param>
        /// <param name="stop"> Date stop print from. </param>
        public void Print(DateTime start, DateTime stop)
        {
            noteBook.MoveStart();
            do
            {
                if (noteBook.GetCurrentNote().creatingTime > start &&
                    noteBook.GetCurrentNote().creatingTime < stop)
                {
                    Console.WriteLine(noteBook.GetCurrentNote().ToString());
                }
            }
            while (noteBook.MoveNext());
        }

        public void Print(DateTime dateOfNote)
        {
            if (noteBook.GetNoteByDate(dateOfNote) != null)
            {

            }
        }

///-данные об одной записи,
    }
}
