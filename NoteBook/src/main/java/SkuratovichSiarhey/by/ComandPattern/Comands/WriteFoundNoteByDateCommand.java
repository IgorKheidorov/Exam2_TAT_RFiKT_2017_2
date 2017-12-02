package SkuratovichSiarhey.by.ComandPattern.Comands;
import SkuratovichSiarhey.by.ComandPattern.Command;
import SkuratovichSiarhey.by.NoteBook;
import SkuratovichSiarhey.by.NoteBookConsoleView;

/**
 * Implements users command of writing found notes by specified date in specified NoteBook.
 */
public class WriteFoundNoteByDateCommand implements Command {
  private NoteBook noteBook;
  private String date;

  public WriteFoundNoteByDateCommand(NoteBook noteBook, String date) {
    this.noteBook = noteBook;
    this.date = date;
  }

  /**
   * Writes found notes by date in NoteBook.
   */
  public void execute() {
    NoteBookConsoleView noteBookConsoleView = new NoteBookConsoleView(noteBook);
    noteBookConsoleView.print(noteBook.findByDate(date));
  }
}
