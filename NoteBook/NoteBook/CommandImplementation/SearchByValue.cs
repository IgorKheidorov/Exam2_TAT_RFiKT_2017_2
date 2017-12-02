
namespace Notebook.CommandImplementation
{
  /// <summary>
  /// This class implements search by value function.
  /// </summary>
  class SearchByValue : Command
  {
    NoteBook noteBook;
    string value;
    Note resultOfSearch;
    public SearchByValue(NoteBook noteBook, string value)
    {
      this.noteBook = noteBook;
      this.value = value;
    }

    /// <summary>
    /// Executes SearchByValue method from NoteBook.
    /// </summary>
    public void Execute()
    {
      resultOfSearch = noteBook.SearchByValue(value);
    }
  }
}
