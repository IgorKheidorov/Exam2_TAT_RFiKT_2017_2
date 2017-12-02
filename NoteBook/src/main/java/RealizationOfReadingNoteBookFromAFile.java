import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.ObjectInputStream;

/**
 * This function reads data from a file.
 */
public class RealizationOfReadingNoteBookFromAFile implements Command {
  String path;

  /**
   * This is construct.
   * @param pathname is a transmitted path.
   * @throws FileNotFoundException if there is no such file
   */
  RealizationOfReadingNoteBookFromAFile (String pathname) throws FileNotFoundException {
    this.path = pathname;
  }

  /**
   * This function reads data from a file.
   * @throws Exception if there is no such path.
   */
  public void execute() throws Exception {
    try {
    FileInputStream fileInputStream = new FileInputStream(new File(path));
    ObjectInputStream objectInputStream = new ObjectInputStream(fileInputStream);
    NoteBook noteBook = (NoteBook) objectInputStream.readObject();
  } catch (FileNotFoundException e) {
      System.out.println("There is no such path");
    }
  }
}
