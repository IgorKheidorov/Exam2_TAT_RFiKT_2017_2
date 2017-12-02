import java.util.ArrayList;

/**
 * This class realize create notebook method.
 */

public class CreateNoteBookCommand implements Command {
  NoteBook noteBook;

  /**
   * This method override execute method from Command interface for createNotebook method.
   */

  public void execute() {
    ArrayList<Note> notes = new ArrayList<Note>();
    NoteBook noteBook = new NoteBook(notes);
  }
}