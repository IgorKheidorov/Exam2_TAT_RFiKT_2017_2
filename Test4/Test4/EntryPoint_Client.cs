using System;
using System.Collections.Generic;

namespace Test4
{
  class EntryPoint_Client
  {
    static void Main(string[] args)
    {
      try
      {
        DateTime dateTime = new DateTime(31, 12, 12);
        List<Note> notes = new List<Note>();
        notes.Add(new Note("1", "2", dateTime));
        notes.Add(new Note("1", "2", dateTime));
        notes.Add(new Note("14", "28", dateTime));
        notes.Add(new Note("1", "2", dateTime));
        notes.Add(new Note("1", "2", dateTime));

        NoteBook noteBook = new NoteBook("1", notes, dateTime);

        Provider provider = new Provider(
          new CreateNewNotebook(noteBook),
          new AddNoteInNoteBook(noteBook),
          new FindNotesInNotebookByContent(noteBook),
          new FindNotesInNotebookByDateCreation(noteBook),
          new ShowNotesInNotebook(noteBook),
          new WriteNotebookInFile(noteBook),
          new DownloadNotebookFromFile(noteBook));

        provider.CreateNewNoteBookRecord();
        provider.AddNoteInNoteBookRecord();
        provider.FindNotesInNotebookByContentRecord();
        provider.FindNotesInNotebookByDateCreationRecord();
        provider.ShowNotesInNotebookRecord();
        provider.WriteNotebookInFileRecord();
        provider.DownloadNotebookFromFileRecord();
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
