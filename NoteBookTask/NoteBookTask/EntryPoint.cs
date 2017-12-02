using System.Collections.Generic;

namespace NoteBookTask
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Note note = new Note();
            note.Name = "Note";
            note.Text = "This is new note";

            WorkerWithNoteBook worker = new WorkerWithNoteBook();
            NoteBookProvider provider = new NoteBookProvider();

            List<ICommand> commands = new List<ICommand>();
            commands.Add(new CreateNoteBook(provider));
            commands.Add(new AddNote(provider, note));
            commands.Add(new DisplayNotes(provider));
            
            foreach (var command in commands)
            {
                worker.SetCommand(command);
                worker.Run();
            }
        }
    }
}
 