using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookTask
{
    class WriteNoteBookToFile : ICommand
    {
        private NoteBookProvider receiver;

        public WriteNoteBookToFile(NoteBookProvider receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.WriteNoteBookToFile();
        }

        public void Undo()
        { }
    }
}
