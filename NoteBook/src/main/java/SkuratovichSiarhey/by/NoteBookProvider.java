package SkuratovichSiarhey.by;

import SkuratovichSiarhey.by.ComandPattern.Command;

/**
 * An user of NoteBook.
 * Can implements specified commands.
 */
public class NoteBookProvider {
  Command showNotesCommand;
  Command writeFoundNoteByDateCommand;
  Command writeFoundNoteByContentCommand;

  public NoteBookProvider(Command showNotesCommand, Command writeFoundNoteByContentCommand, Command writeFoundNoteByDateCommand) {
    this.showNotesCommand = showNotesCommand;
    this.writeFoundNoteByContentCommand = writeFoundNoteByContentCommand;
    this.writeFoundNoteByDateCommand = writeFoundNoteByDateCommand;
  }

  /**
   * Writes found notes by content in NoteBook.
   */
  void writeFoundNoteByContentCommand() {
    writeFoundNoteByContentCommand.execute();
  }

  /**
   * Writes found notes by date in NoteBook.
   */
  void writeFoundNoteByDateCommand() {
    writeFoundNoteByDateCommand.execute();
  }

  /**
   * Shows full list of notes.
   */
  void showNotesCommand() {
    showNotesCommand.execute();
  }

}
