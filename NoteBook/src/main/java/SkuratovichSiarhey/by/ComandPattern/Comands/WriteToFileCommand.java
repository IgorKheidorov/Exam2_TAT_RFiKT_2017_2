package SkuratovichSiarhey.by.ComandPattern.Comands;
import SkuratovichSiarhey.by.ComandPattern.Command;
import SkuratovichSiarhey.by.NoteBook;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 * Implements users command of writing NoteBook to File.
 */
public class WriteToFileCommand implements Command {

  private static Logger log = Logger.getLogger(WriteToFileCommand.class.getName());
  private NoteBook noteBook;
  private String path;

  public WriteToFileCommand(NoteBook noteBook, String path) {
    this.noteBook = noteBook;
    this.path = path;
  }

  /**
   * Writes notes to file.
   */
  public void execute() {
    try {
      File file = new File(path);
      BufferedWriter writer = new BufferedWriter(new FileWriter(file));
      writer.write(noteBook.getName());
      StringBuffer fullList = new StringBuffer();
      writer.write(noteBook.getFullList());
      writer.flush();
      writer.close();
    } catch (IOException ex) {
      log.log(Level.SEVERE, "IOException while writing", ex);
    }

  }
}
