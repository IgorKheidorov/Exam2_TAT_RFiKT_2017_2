package SkuratovichSiarhey.by.ComandPattern.Comands;

import SkuratovichSiarhey.by.NoteBook;
import SkuratovichSiarhey.by.NoteBookProvider;

/**
 * Created by siarhey on 02.12.17.
 */
public class WriteFoundNoteByDateCommand {
  private NoteBook noteBook;
  private String content;

  public WriteFoundNoteByDateCommand(NoteBook noteBook, String content) {
    this.noteBook = noteBook;
    this.content = content;
  }

  public void execute() {
    NoteBookProvider noteBookProvider = new NoteBookProvider();
    noteBookProvider.print(noteBook.findByDate(content));
  }
}
