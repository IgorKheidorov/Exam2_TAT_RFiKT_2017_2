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

    public void CreateNewNoteBookRecord()
    {
      createNewNoteBook.Execute();
    }

    public void AddNoteInNoteBookRecord()
    {
      addNoteInNoteBook.Execute();
    }

    public void FindNotesInNotebookByContentRecord()
    {
      findNotesInNotebookByContent.Execute();
    }

    public void FindNotesInNotebookByDateCreationRecord()
    {
      findNotesInNotebookByDateCreation.Execute();
    }

    public void ShowNotesInNotebookRecord()
    {
      showNotesInNotebook.Execute();
    }

    public void WriteNotebookInFileRecord()
    {
      writeNotebookInFile.Execute();
    }

    public void DownloadNotebookFromFileRecord()
    {
      downloadNotebookFromFile.Execute();
    }

  }
}
