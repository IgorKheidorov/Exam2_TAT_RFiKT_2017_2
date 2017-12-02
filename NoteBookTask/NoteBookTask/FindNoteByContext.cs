using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookTask
{
    public class FindNoteByContext : ICommand
    {
        private NoteBookProvider receiver;
        public string Text { get; set; }

        public FindNoteByContext(NoteBookProvider receiver, string text)
        {
            this.receiver = receiver;
            this.Text = text;
        }

        public void Execute()
        {
            receiver.FindNoteByContext(Text);
        }

        public void Undo()
        { }
    }
}
