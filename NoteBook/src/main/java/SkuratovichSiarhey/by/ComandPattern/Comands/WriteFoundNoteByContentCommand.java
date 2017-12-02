package SkuratovichSiarhey.by.ComandPattern.Comands;
import SkuratovichSiarhey.by.ComandPattern.Command;
import SkuratovichSiarhey.by.NoteBook;
import SkuratovichSiarhey.by.NoteBookConsoleView;
import SkuratovichSiarhey.by.NoteBookProvider;

/**
 * Created by siarhey on 02.12.17.
 */
public class WriteFoundNoteByContentCommand implements Command{

  private NoteBook noteBook;
  private String content;

  public WriteFoundNoteByContentCommand(NoteBook noteBook, String content) {
    this.noteBook = noteBook;
    this.content = content;
  }

  public void execute() {
    /*NoteBookConsoleView noteBookConsoleView = new NoteBookConsoleView(noteBook);
    noteBookConsoleView.print(noteBook.findByContent(content));*/
  }
}
