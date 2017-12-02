using System;

namespace Notebook.CommandImplementation
{
  /// <summary>
  /// This class implements search by time of creation function.
  /// </summary>
  public class SearchByTimeOfCreation : Command
  {
    NoteBook noteBook;
    DateTime time;
    Note resultOfSearch;
    public SearchByTimeOfCreation(NoteBook noteBook, DateTime time)
    {
      this.noteBook = noteBook;
      this.time = time;
    }

    /// <summary>
    /// Executes SearchByTimeOfCreation method from NoteBook.
    /// </summary>
    public void Execute()
    {
      resultOfSearch = noteBook.SearchByTimeOfCreation(time);
    }
  }
}
