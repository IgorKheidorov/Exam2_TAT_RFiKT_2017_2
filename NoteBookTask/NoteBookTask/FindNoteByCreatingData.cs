using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookTask
{
    class FindNoteByCreatingData : ICommand
    {
        private NoteBookProvider receiver;
        public DateTime Data { get; set; }

        public FindNoteByCreatingData(NoteBookProvider receiver, DateTime Data)
        {
            this.receiver = receiver;
            this.Data = Data;
        }

        public void Execute()
        {
            receiver.FindNoteByCreatingData(Data);
        }

        public void Undo()
        { }
    }
}
