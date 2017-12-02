package SkuratovichSiarhey.by.ComandPattern.Comands;

import SkuratovichSiarhey.by.Note;
import SkuratovichSiarhey.by.NoteBook;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 * Created by siarhey on 02.12.17.
 */
public class ReadFromFileCommand {

  private static Logger log = Logger.getLogger(ReadFromFileCommand.class.getName());
  private NoteBook noteBook;
  private String path;

  public ReadFromFileCommand(NoteBook noteBook, String path) {
    this.noteBook = noteBook;
    this.path = path;
  }

  /**
   * Reads notes to NoteBook object.
   * Reading provides only for special files in specified form like while writing.
   */
  public void execute() {
    try {
      File file = new File(path);
      BufferedReader bufferedReader = new BufferedReader(new FileReader(file));
      while (bufferedReader.ready()) {
        bufferedReader.readLine();
        Note note = new Note(bufferedReader.readLine(), bufferedReader.readLine());
        note.setDate(bufferedReader.readLine());
        noteBook.addNote(note);
        bufferedReader.readLine();
        bufferedReader.readLine();
      }
      bufferedReader.close();
    } catch (IOException ex) {
      log.log(Level.SEVERE, "IOException while reading", ex);
    }
  }
}
