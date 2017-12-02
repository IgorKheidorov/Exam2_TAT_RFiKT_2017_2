using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookTask
{
    public class CreateNoteBook : ICommand
    {
        NoteBookProvider receiver;

        public CreateNoteBook(NoteBookProvider receiver)
        {
            this.receiver = receiver;
        }
        public void Execute()
        {
            receiver.CreateNoteBook();
        }

        public void Undo()
        { }
    }
}
