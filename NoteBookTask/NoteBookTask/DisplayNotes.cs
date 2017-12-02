using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookTask
{
    class DisplayNotes : ICommand
    {
        private NoteBookProvider receiver;

        public DisplayNotes(NoteBookProvider receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.DisplayNotes();
        }

        public void Undo()
        { }
    }
}
