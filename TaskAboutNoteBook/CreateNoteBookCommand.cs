using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAboutNoteBook
{
  class CreateNoteBookCommand : Command
  {
    private NoteBookProvider noteBookProvider;

    public CreateNoteBookCommand(NoteBookProvider noteBookProvider)
    {
      this.noteBookProvider = noteBookProvider;
    }



    public void Execute()
    {
      noteBookProvider.CreateNoteBook();
    }

  
  }
}
