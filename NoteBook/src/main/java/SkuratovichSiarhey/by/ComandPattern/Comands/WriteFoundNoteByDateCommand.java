package SkuratovichSiarhey.by.ComandPattern.Comands;

import SkuratovichSiarhey.by.ComandPattern.Command;
import SkuratovichSiarhey.by.NoteBook;
import SkuratovichSiarhey.by.NoteBookConsoleView;
import SkuratovichSiarhey.by.NoteBookProvider;

/**
 * Created by siarhey on 02.12.17.
 */
public class WriteFoundNoteByDateCommand implements Command {
  private NoteBook noteBook;
  private String date;

  public WriteFoundNoteByDateCommand(NoteBook noteBook, String date) {
    this.noteBook = noteBook;
    this.date = date;
  }

  public void execute() {
    /*NoteBookConsoleView noteBookConsoleView = new NoteBookConsoleView();
    noteBookConsoleView.print(noteBook.findByDate(date));;*/
  }
}
