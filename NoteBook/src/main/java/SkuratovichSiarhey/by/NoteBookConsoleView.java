package SkuratovichSiarhey.by;

/**
 * Created by siarhey on 02.12.17.
 */
public class NoteBookConsoleView {
  private NoteBook noteBook;

  public NoteBookConsoleView(NoteBook noteBook) {
    this.noteBook = noteBook;
  }

  /**
   * Prints note at gotten index.
   * The index is counted from 1.
   * @param i the index of note we are looking for.
   */
  public void print(int i) {
    System.out.println(i + ")\n" + noteBook.getNotes().get(i - 1).getHead() + "\n" +
            noteBook.getNotes().get(i - 1).getContent() + "\n" +
            noteBook.getNotes().get(i - 1).getDate());
  }

  /**
   * Prints notes from start-index to end-index inclusively.   .
   * The index is counted from 1.
   * @param start the starting index of note from which we are printing.
   * @param end the ending index of note to which we are printing.
   */
  public void print(int start, int end) {
    for (int i = start; i <= end; i++) {
      System.out.println(i + ")\n" + noteBook.getNotes().get(i - 1).getHead() + "\n" +
              noteBook.getNotes().get(i - 1).getContent() + "\n" +
              noteBook.getNotes().get(i - 1).getDate());
      if(i != noteBook.getNotes().size()) {
        System.out.println();;
      }
    }
  }

  /**
   * Prints full list of notes.
   * @param string Printing provides if gotten string is equal "full".
   */
  public void print(String string) throws IllegalArgumentException {
    if (string.equals("full")) {
      for (int i = 0; i < noteBook.getNotes().size(); i++) {
        System.out.println(i + 1 +")\n" + noteBook.getNotes().get(i).getHead() + "\n" +
                noteBook.getNotes().get(i).getContent() + "\n" +
                noteBook.getNotes().get(i).getDate());
        if (i != noteBook.getNotes().size() - 1) {
          System.out.println();
          ;
        }
      }
    } else {
      throw new IllegalArgumentException("Unknown command");
    }
  }
}
