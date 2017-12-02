package SkuratovichSiarhey.by.ComandPattern.Comands;

import SkuratovichSiarhey.by.ComandPattern.Command;
import SkuratovichSiarhey.by.NoteBook;
import SkuratovichSiarhey.by.NoteBookConsoleView;

/**
 * Implements users command of showing full list of notes.
 */
public class ShowNotesCommand implements Command {
  private NoteBook noteBook;

  public ShowNotesCommand(NoteBook noteBook) {
    this.noteBook = noteBook;
  }

  /**
   * Shows full list of notes.
   */
  public void execute() {
    NoteBookConsoleView noteBookConsoleView = new NoteBookConsoleView(noteBook);
    noteBookConsoleView.print("full");
  }
}
