/**
 * This class realize found by value method in notebook.
 */

public class FoundByValueCommand implements Command {
  NoteBook noteBook;
  String value;
  public FoundByValueCommand(NoteBook noteBook, String value) {
    this.value = value;
    this.noteBook = noteBook;
  }
  /**
   * This method override method execute from Command interface for method, that
   * found note by value.
   */

  public void execute() {
//    Scanner scanner = new Scanner(System.in);
//    String value = scanner.next();
    NoteBookConsoleView noteBookConsoleView = new NoteBookConsoleView();
    Note foundNode = null;
    for (int i = 0; i < noteBook.getNotes().size(); i++) {
      if (noteBook.getNotes().get(i).getValue().equals(value)) {
        foundNode = noteBook.getNotes().get(i);
      }
    }
    if (!(foundNode == null)) {
      noteBookConsoleView.print(foundNode);
    }
  }
}