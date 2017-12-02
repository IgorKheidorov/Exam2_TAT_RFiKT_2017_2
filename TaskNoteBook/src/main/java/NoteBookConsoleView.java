/**
 * Prints the data from the NoteBook to the console.
 */
public class NoteBookConsoleView {

  /**
   * Prints one note from the NoteBook to the console.
   *
   * @param noteBook  the note that will be printed
   * @param noteIndex index of the note in the NoteBook
   */
  public void print(NoteBook noteBook, int noteIndex) {
    if (noteIndex >= noteBook.getListOfNotes().size() || noteIndex < 0) {
      throw new ArrayIndexOutOfBoundsException();
    }
    System.out.print(noteBook.getListOfNotes().toArray()[noteIndex].toString());
  }

  /**
   * Prints a several notes from the NoteBook to the console.
   *
   * @param noteBook  the NoteBook
   * @param noteIndex index of the notes in the NoteBook
   */
  public void print(NoteBook noteBook, int... noteIndex) {
    for (int i = 0; i < noteIndex.length; i++) {
      if (noteIndex[i] >= noteBook.getListOfNotes().size() || noteIndex[i] < 0) {
        throw new ArrayIndexOutOfBoundsException();
      }
      System.out.print(noteBook.getListOfNotes().toArray()[noteIndex[i]].toString());
    }
  }

  /**
   * Prints the whole NoteBook to the console.
   *
   * @param noteBook the NoteBook that will be printed
   */
  public void print(NoteBook noteBook) {
    System.out.print(noteBook.toString());
  }
}
