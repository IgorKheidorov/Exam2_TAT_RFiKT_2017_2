import java.util.Date;

/**
 * This class realize add Note to notebook.
 */

public class AddNoteCommand implements Command{
  NoteBook noteBook;
  String value;
  public AddNoteCommand(NoteBook noteBook, String value) {
    this.value = value;
    this.noteBook = noteBook;
  }
  public void setValue(String value) {
    this.value = value;
  }

  /**
   * This method override method execute from Command interface for addNote method.
   */
  public void execute() {
    Date date = new Date();
    Note note = new Note(value, date);
    noteBook.getNotes().add(note);
  }
}