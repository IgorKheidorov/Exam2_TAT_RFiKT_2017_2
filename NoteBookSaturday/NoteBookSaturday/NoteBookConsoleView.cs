using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookSaturday
{
    /// <summary>
    /// Class for viewing notebook by printing data on console.
    /// </summary>
    public class NoteBookConsoleView
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

        /// <summary>
        /// Print note with certain date.
        /// </summary>
        /// <param name="dateOfNote"> Date of note to print. </param>
        public void Print(DateTime dateOfNote)
        {
            Console.WriteLine(noteBook.GetNoteByDate(dateOfNote) == null ? 
                "Note with such date do not exist." : 
                noteBook.GetNoteByDate(dateOfNote).ToString());
        }

        /// <summary>
        /// If choose is 1, function find by title, else by record.
        /// </summary>
        /// <param name="dateOfNote"> Text of title or record. </param>
        /// <param name="choose"> If choose = 1, function find by title, else by record. </param>
        public void Print(string dataFromNote, int choose)
        {
            if (choose == 1)
            {
                Console.WriteLine(noteBook.GetNoteByTitle(dataFromNote) == null ?
                                "Note with such title do not exist." :
                                noteBook.GetNoteByTitle(dataFromNote).ToString());
            }
            else
            {
                Console.WriteLine(noteBook.GetNoteByRecord(dataFromNote) == null ?
                                "Note with such record do not exist." :
                                noteBook.GetNoteByRecord(dataFromNote).ToString());
            }
        }
    }
}
