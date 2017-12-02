package SkuratovichSiarhey.by;

import SkuratovichSiarhey.by.ComandPattern.Command;

/**
 * Created by siarhey on 02.12.17.
 */
public class User {
  Command showNotesCommand;
  Command writeFoundNoteByDateCommand;
  Command writeFoundNoteByContentCommand;

  public User(Command showNotesCommand, Command writeFoundNoteByContentCommand, Command writeFoundNoteByDateCommand) {
    this.showNotesCommand = showNotesCommand;
    this.writeFoundNoteByContentCommand = writeFoundNoteByContentCommand;
    this.writeFoundNoteByDateCommand = writeFoundNoteByDateCommand;
  }

  void writeFoundNoteByContentCommand() {
    writeFoundNoteByContentCommand.execute();
  }

  void writeFoundNoteByDateCommand() {
    writeFoundNoteByDateCommand.execute();
  }

  void showNotesCommand() {
    showNotesCommand.execute();
  }
}
