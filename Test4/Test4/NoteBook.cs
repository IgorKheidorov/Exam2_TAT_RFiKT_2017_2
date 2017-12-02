using System.Collections.Generic;
using System.Text;
using System;

namespace Test4
{
  /// <summary>
  /// This class realizes notebook.
  /// </summary>
  public class NoteBook
  {
    private string nameOfNoteBook;
    private List<Note> listOfNotes = new List<Note>();
    private string dateOfCreation;

    /// <summary>
    /// This constructor determines fields of class.
    /// </summary>
    /// <param name="nameOfNoteBook">Name of notebook.</param>
    /// <param name="listOfNotes">Notes in the notebook.</param>
    /// <param name="dateOfCreation">Date of creation of notebook.</param>
    public NoteBook(string nameOfNoteBook, List<Note> listOfNotes, DateTime dateOfCreation)
    {
      this.nameOfNoteBook = nameOfNoteBook;
      this.listOfNotes = listOfNotes;
      this.dateOfCreation = dateOfCreation.ToString();
      validateNote();
    }

    /// <summary>
    /// This method returns hash of notebook.
    /// </summary>
    /// <returns>Returns hash of notebook.</returns>
    public override int GetHashCode()
    {
      int resultHash = 0;
      foreach (Note note in listOfNotes)
      {
        resultHash += note.GetHashCode();
      }
      return resultHash;
    }

    /// <summary>
    /// This method returns information about notebook.
    /// </summary>
    /// <returns>Returns string with information about notebook.</returns>
    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("Name of notebook: ");
      stringBuilder.Append(nameOfNoteBook);
      stringBuilder.Append(", date of creation: ");
      stringBuilder.Append(dateOfCreation);
      return stringBuilder.ToString();
    }

    /// <summary>
    /// This method checks whether notebook and object are equal.
    /// </summary>
    /// <param name="obj">The second object with which a comparison is made.</param>
    /// <returns>Returns true if objects are equal, and false if not.</returns>
    public override bool Equals(object obj)
    {
      if (obj == null)
      {
        return false;
      }

      NoteBook notebook = obj as NoteBook;

      if (notebook == null)
      {
        return false;
      }

      return nameOfNoteBook == notebook.nameOfNoteBook
        && listOfNotes == notebook.listOfNotes && dateOfCreation == notebook.dateOfCreation;
    }

    private void validateNote()
    {
      if (nameOfNoteBook == String.Empty)
      {
        throw new ArgumentException();
      }
    }

    /// <summary>
    /// This method creates new notebook.
    /// </summary>
    public void CreateNewNoteBook()
    {
      NoteBookProvider provider = new NoteBookProvider();
      NoteBook noteBook = new NoteBook(provider.EnterName(),
        provider.EnterNotes(), provider.EnterDateOfCreation());
    }

    /// <summary>
    /// This method adds new note in the notebook.
    /// </summary>
    public void AddNoteInNoteBook()
    {
      NoteProvider noteProvider = new NoteProvider();
      listOfNotes.Add(new Note(noteProvider.EnterName(), noteProvider.EnterData(),
        noteProvider.EnterDateOfCreation()));
    }

    /// <summary>
    /// This method finds notes in notebook by content.
    /// </summary>
    public void FindNotesInNotebookByContent()
    {
      
    }

    /// <summary>
    /// This method finds notes in notebook by date of creation.
    /// </summary>
    public void FindNotesInNotebookByDateCreation()
    {

    }

    /// <summary>
    /// This method shows notes in notebook.
    /// </summary>
    public void ShowNotesInNotebook()
    {

    }

    /// <summary>
    /// This method writes notebook in file.
    /// </summary>
    public void WriteNotebookInFile()
    {

    }

    /// <summary>
    /// This method download notebook from file.
    /// </summary>
    public void DownloadNotebookFromFile()
    {

    }

    public List<Note> ListOfNotes { get { return listOfNotes; } }
  }
}
