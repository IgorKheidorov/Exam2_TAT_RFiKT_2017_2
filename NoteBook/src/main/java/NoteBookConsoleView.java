/**
 * This class is for console presentation of notes from a notebook.
 */
public class NoteBookConsoleView {
  NoteBook noteBook;

  /**
   * This method is override print method for notes from a notebook.
   * @param notes - this param can has different count of values.
   */
  public void print(Note...notes) {
    for (Note x : notes) {
      System.out.println(notes.toString());
    }
  }
}