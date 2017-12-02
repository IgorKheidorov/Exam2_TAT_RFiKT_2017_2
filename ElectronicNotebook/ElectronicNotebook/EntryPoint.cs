using System;
using System.Collections.Generic;

namespace ElectronicNotebook
{
    /// <summary>
    /// Entry point to the program that realizes electronic notebook.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main method of the program.
        /// </summary>
        /// <param name="args">Params from command line.</param>
        static void Main(string[] args)
        {
            try
            {
                IProvidable noteProvidable = new ConsoleReader();
                Note note = new Note();
                DateTimeOffset date = DateTimeOffset.Now;

                NoteBookEditor editor = new NoteBookEditor();
                NoteBookReceiver rec = new NoteBookReceiver(noteProvidable);
                List<ICommand> commands = new List<ICommand>{};
                commands.Add(new CreateNoteBookCommand(rec));
                commands.Add(new AddNotesCommand (rec, note));
                commands.Add(new FindByContextCommand(rec, "bla"));
                commands.Add(new FindByDateCommand(rec, date));
                commands.Add(new ShowNotesCommand(rec));
                foreach(var command in commands)
                {
                    editor.SetCommand(command);
                    editor.Run();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
