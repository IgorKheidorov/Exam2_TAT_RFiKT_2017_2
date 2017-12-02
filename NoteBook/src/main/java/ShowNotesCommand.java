/**
 * This class realize method, that show notes from a Command interface.
 */
public class ShowNotesCommand implements Command {
  NoteBook noteBook;
  public ShowNotesCommand(NoteBook noteBook) {
    this.noteBook = noteBook;
  }

  /**
   * This method is override execute method for show notes.
   */
  public void execute() {
    System.out.println(noteBook.toString());
  }
}