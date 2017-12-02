using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookTask
{
    class ReadNoteBookFromFile : ICommand
    {
        private NoteBookProvider receiver;

        public ReadNoteBookFromFile(NoteBookProvider receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.ReadNoteBookFromFile();
        }

        public void Undo()
        { }
    }
}