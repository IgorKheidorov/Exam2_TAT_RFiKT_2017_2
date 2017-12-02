import java.util.ArrayList;

/**
 * This class adding notes
 */
public class AddingNote implements Command {
  NoteBook book;
  Note note;

  /**
   * This is constructor.
   * @param noteBook is transmitted notebook
   * @param entry is transmitted note.
   */
  public AddingNote(NoteBook noteBook, Note entry) {
    this.book = noteBook;
    this.note = entry;
  }

  /**
   * This function setting note.
   */
  public void execute() {
    book.setNote(note);
  }
}
