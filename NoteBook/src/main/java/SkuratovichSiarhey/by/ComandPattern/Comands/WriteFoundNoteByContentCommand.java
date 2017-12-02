package SkuratovichSiarhey.by.ComandPattern.Comands;
import SkuratovichSiarhey.by.ComandPattern.Command;
import SkuratovichSiarhey.by.NoteBook;
import SkuratovichSiarhey.by.NoteBookConsoleView;
import SkuratovichSiarhey.by.NoteBookProvider;

/**
 * Implements users command of writing found notes by specified content in specified NoteBook.
 */
public class WriteFoundNoteByContentCommand implements Command{

  private NoteBook noteBook;
  private String content;

  public WriteFoundNoteByContentCommand(NoteBook noteBook, String content) {
    this.noteBook = noteBook;
    this.content = content;
  }

  /**
   * Writes found notes by content in NoteBook.
   */
  public void execute() {
    NoteBookConsoleView noteBookConsoleView = new NoteBookConsoleView(noteBook);
    noteBookConsoleView.print(noteBook.findByContent(content));
  }
}
