using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Scratchpad
{
  public partial class NoteBook
  {
    private static readonly string PATHFROMREAD = "E:\\Desktop\\read.txt";
    private static readonly string PATHFORWRITING = "E:\\Desktop\\";

    /// <summary>
    /// Download notes from file to NoteBook
    /// </summary>
    /// <returns>NoteBook</returns>
    public void DownloadNoteBookFromFile()
    {
      NewNoteBook = new List<Note>();
      using (StreamReader reader = new StreamReader(PATHFROMREAD, Encoding.Default))
      {
        while (!reader.EndOfStream)
        {
          DateTime date = Convert.ToDateTime(reader.ReadLine());
          string value = reader.ReadLine();
          NewNoteBook.Add(new Note(value, date));
        }
      }
    }

    /// <summary>
    /// Write the NoteBook into the file.txt
    /// </summary>
    public void WriteNewNoteInNewFile()
    {
      using (StreamWriter writer = new StreamWriter(new FileStream(PATHFORWRITING + "file.txt", FileMode.Create)))
      {
        foreach (var element in NewNoteBook)
        {
          writer.Write(element.ToString());
        }
      }
    }
  }
}
