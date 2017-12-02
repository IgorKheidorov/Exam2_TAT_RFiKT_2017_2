using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicNoteBookTask
{
    /// <summary>
    /// Main class of program which realized electronic NoteBook
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            NoteBook noteBook = new NoteBook();
            NoteBookProvider noteBookProvider = new NoteBookProvider();
            invoker.SetCommand(new CreateNoteBookCommand(noteBookProvider, noteBook));
            invoker.Run();
            Note note = new Note("mamapapa", "family");
            invoker.SetCommand(new AddNoteCommand(noteBookProvider, noteBook, note));
            invoker.Run();
            string content = "family";
            ICommand command = new SearchNoteByTheContentCommand(noteBookProvider, noteBook, content);
            invoker.SetCommand(command);
            invoker.Run();
        }
    }
}
