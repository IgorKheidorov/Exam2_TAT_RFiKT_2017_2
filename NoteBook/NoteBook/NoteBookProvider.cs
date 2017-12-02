using System;
using System.IO;

namespace NoteBook
{
  /// <summary>
  /// Class for working with NoteBook
  /// </summary>
  public class NoteBookProvider
  {
    private Notebook noteBook = new Notebook();

    /// <summary>
    /// this methode create new object of notebook
    /// </summary>
    /// <returns></returns>
    public NoteBookProvider CreatObject()
    {
      return new NoteBookProvider();
    }

    /// <summary>
    /// This method add new note in final of notebook
    /// </summary>
    /// <param name="note">note which we want add</param>
    public void AddNote(Note note)
    {
      this.noteBook.AddNote(note.Title, note.Data);
    }

    /// <summary>
    /// This methode find note in notebook by data
    /// </summary>
    /// <param name="data"> data which we want find</param>
    public void FindNoteInNoteBookByData(String data)
    {
      noteBook.FindEqualsData(data);
    }

    /// <summary>
    /// this methode find note in notebook by time
    /// </summary>
    /// <param name="time">time with which we want find note</param>
    public void FindNoteInNoteBookByDate(String time)
    {
      noteBook.FindEqualsTime(time);
    }

    /// <summary>
    /// This methode show notes of Notebook
    /// </summary>
    /// <param name="noteBookProvider">what notebook we want show</param>
    public void ShowNotesOfNotebook(NoteBookProvider noteBookProvider)
    {
      NoteBookConsoleView noteBookConsoleView = new NoteBookConsoleView();
      noteBookConsoleView.Print(noteBookProvider.noteBook);
    }

    /// <summary>
    /// This method write all notebook into file
    /// </summary>
    /// <param name="path">where will be file with writed notebook</param>
    public void WriteNoteBookToFile(String path)
    {
      using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
      {
        byte[] array = System.Text.Encoding.Default.GetBytes(noteBook.ToString());
        fstream.Write(array, 0, array.Length);
      }
    }
  }
}
