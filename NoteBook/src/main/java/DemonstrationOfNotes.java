/**
 * This function shows Notes.
 */
public class DemonstrationOfNotes implements Command {
  NoteBook book;
  NoteBookConsoleView show = new NoteBookConsoleView();

  /**
   * This is constructor.
   * @param noteBook transmitted notebook.
   */
  public DemonstrationOfNotes(NoteBook noteBook) {
    this.book = noteBook;
  }

  /**
   * This function is shows notebook.
   * @throws Exception if list is empty.
   */
  public void execute() throws Exception {
      if(book == null) {
        throw new Exception("NoteBook is empty!");
      }
    for (int i = 0; i < book.getNote().size(); i++) {
     show.print(book.getNote().get(i));
    }
  }
}
