/**
 * This class print data depends on transmitting parameters
 */
public class NoteBookConsoleView {

  /**
   * This function prints single note
   * @param note transmitted note
   */
  public void print(Note note) {
    System.out.println("Data of a single note : " + note.toString());
  }

  /**
   * This function prints some notes
   * @param note are transmitting notes.
   */
  public void print(Note... note) {
    for (Object item : note) {
      System.out.println(item.toString());
    }
  }

  /**
   * This function prints notebook
   * @param noteBook transmitted notebook.
   */
  public void print(NoteBook noteBook) {
    System.out.println(noteBook.toString());
  }
}
