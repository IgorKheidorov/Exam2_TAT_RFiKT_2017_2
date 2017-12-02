namespace Test4
{
  /// <summary>
  /// This class works with notebook.
  /// </summary>
  public class Provider
  {
    Command createNewNoteBook;
    Command addNoteInNoteBook;
    Command findNotesInNotebookByContent;
    Command findNotesInNotebookByDateCreation;
    Command showNotesInNotebook;
    Command writeNotebookInFile;
    Command downloadNotebookFromFile;

    /// <summary>
    /// This constructor determines fields of class.
    /// </summary>
    /// <param name="createNewNoteBook">Create new notebook.</param>
    /// <param name="addNoteInNoteBook">Add note in notebook.</param>
    /// <param name="findNotesInNotebookByContent">Find notes in notebook by content.</param>
    /// <param name="findNotesInNotebookByDateCreation">Find notes in notebook by date of creation.</param>
    /// <param name="showNotesInNotebook">Show notes in notebook.</param>
    /// <param name="writeNotebookInFile">Write notebook in file.</param>
    /// <param name="downloadNotebookFromFile">Download notebook from file.</param>
    public Provider(Command createNewNoteBook, Command addNoteInNoteBook, Command findNotesInNotebookByContent,
      Command findNotesInNotebookByDateCreation, Command showNotesInNotebook, Command writeNotebookInFile,
      Command downloadNotebookFromFile)
    {
      this.createNewNoteBook = createNewNoteBook;
      this.addNoteInNoteBook = addNoteInNoteBook;
      this.findNotesInNotebookByContent = findNotesInNotebookByContent;
      this.findNotesInNotebookByDateCreation = findNotesInNotebookByDateCreation;
      this.showNotesInNotebook = showNotesInNotebook;
      this.writeNotebookInFile = writeNotebookInFile;
      this.downloadNotebookFromFile = downloadNotebookFromFile;
    }

    /// <summary>
    /// Calls method Execute() for comand createNewNoteBook.
    /// </summary>
    public void CreateNewNoteBookRecord()
    {
      createNewNoteBook.Execute();
    }

    /// <summary>
    /// Calls method Execute() for comand addNoteInNoteBook.
    /// </summary>
    public void AddNoteInNoteBookRecord()
    {
      addNoteInNoteBook.Execute();
    }

    /// <summary>
    /// Calls method Execute() for comand findNotesInNotebookByContent.
    /// </summary>
    public void FindNotesInNotebookByContentRecord()
    {
      findNotesInNotebookByContent.Execute();
    }

    /// <summary>
    /// Calls method Execute() for comand findNotesInNotebookByDateCreation.
    /// </summary>
    public void FindNotesInNotebookByDateCreationRecord()
    {
      findNotesInNotebookByDateCreation.Execute();
    }

    /// <summary>
    /// Calls method Execute() for comand showNotesInNotebook.
    /// </summary>
    public void ShowNotesInNotebookRecord()
    {
      showNotesInNotebook.Execute();
    }

    /// <summary>
    /// Calls method Execute() for comand writeNotebookInFile.
    /// </summary>
    public void WriteNotebookInFileRecord()
    {
      writeNotebookInFile.Execute();
    }

    /// <summary>
    /// Calls method Execute() for comand downloadNotebookFromFile.
    /// </summary>
    public void DownloadNotebookFromFileRecord()
    {
      downloadNotebookFromFile.Execute();
    }
  }
}
