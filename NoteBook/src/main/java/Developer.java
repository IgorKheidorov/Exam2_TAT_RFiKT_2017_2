import java.io.FileNotFoundException;
import java.text.ParseException;

/**
 * This class call realizations execute methods for all command execute methods.
 */

public class Developer {
  Command addNote;
  Command createNoteBook;
  Command foundByValue;
  Command foundByDate;
  Command showNotes;
  Command loadNotebookFromFile;

  public Developer(Command addNote, Command createNoteBook, Command foundByDate,
                   Command foundByValue, Command showNotes, Command loadNotebookFromFile) {
    this.addNote = addNote;
    this.createNoteBook = createNoteBook;
    this.foundByDate = foundByDate;
    this.foundByValue = foundByValue;
    this.showNotes = showNotes;
    this.loadNotebookFromFile = loadNotebookFromFile;
  }

  /**
   * Here all execute realizations for each method are called.
   */
  public void addNoteRecord() throws ParseException, FileNotFoundException {
    addNote.execute();
  }
  public void createNoteBookRecord() throws ParseException, FileNotFoundException {
    createNoteBook.execute();
  }
  public void foundByValueRecord() throws ParseException, FileNotFoundException {
    foundByValue.execute();
  }
  public void foundByDateRecord() throws ParseException, FileNotFoundException {
    foundByDate.execute();
  }
  public void showNotesRecord() throws ParseException, FileNotFoundException {
    showNotes.execute();
  }
  public void loadNotebookFromFileRecord() throws ParseException, FileNotFoundException {
    loadNotebookFromFile.execute();
  }
}