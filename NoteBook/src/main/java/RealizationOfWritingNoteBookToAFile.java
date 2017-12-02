import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.ObjectOutputStream;

/**
 * This function writes data in a file.
 */
public class RealizationOfWritingNoteBookToAFile implements Command {
  NoteBook noteBook;
  String path;

  /**
   * This is constructor.
   * @param note is a transmitted note
   * @param pathname is a transmitted path
   * @throws FileNotFoundException if there is no file.
   */
  RealizationOfWritingNoteBookToAFile (NoteBook note,String pathname) throws FileNotFoundException {
    this.path = pathname;
    this.noteBook = note;
  }

  /**
   * This function writes data in a file.
   * @throws Exception if there is no such path.
   */
  public void execute() throws Exception {
    try {
      FileOutputStream fileOutputStream = new FileOutputStream(new File(path));
      ObjectOutputStream objectOutputStream = new ObjectOutputStream(fileOutputStream);
      objectOutputStream.writeObject(noteBook);
      objectOutputStream.close();
    } catch (FileNotFoundException ex) {
      System.out.println("There is no such path");
    }
  }
}
