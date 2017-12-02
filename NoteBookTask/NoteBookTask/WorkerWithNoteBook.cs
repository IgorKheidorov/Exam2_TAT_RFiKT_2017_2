using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookTask
{
    //invoker
    public class WorkerWithNoteBook
    {
        private ICommand command;
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
        public void Run()
        {
            command.Execute();
        }
        public void Cancel()
        {
            command.Undo();
        }
    }
}