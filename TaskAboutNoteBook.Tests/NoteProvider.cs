using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAboutNoteBook.Tests
{
 
  class NoteProvider
  {
    private string title = "title";
    private string data = "data";
    public Note GetNote()
    {
      return new Note(data,title);
    }
  }
}
