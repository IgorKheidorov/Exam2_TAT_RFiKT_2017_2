using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookTask
{
    class AddNote : ICommand
    {
        private NoteBookProvider receiver;
        public Note Note { get; set; }

        public AddNote(NoteBookProvider receiver, Note note)
        {
            this.receiver = receiver;
            this.Note = note;
        }
        public void Execute()
        {
            receiver.AddNote(Note);
        }

        public void Undo()
        { }
    }
}
