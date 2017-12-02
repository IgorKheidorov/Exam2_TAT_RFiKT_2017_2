using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAboutNoteBook
{
  public class LoadNoteBookFromFileCommand : Command
  {
    private NoteBookProvider noteBookProvider;


    public LoadNoteBookFromFileCommand(NoteBookProvider noteBookProvider)
    {   
      this.noteBookProvider = noteBookProvider;    
    }



    public void Execute()
    {
      Console.WriteLine("Enter path of file :");
      noteBookProvider.LoadNoteBookFromFile(Console.ReadLine());
    }
  }
}
