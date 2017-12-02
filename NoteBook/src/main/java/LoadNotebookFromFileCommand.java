import java.io.File;
import java.io.FileNotFoundException;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Locale;
import java.util.Scanner;

public class LoadNotebookFromFileCommand implements Command {
  /**
   * This class realize load notebook from a file.
   */
  NoteBook noteBook;
  public LoadNotebookFromFileCommand(NoteBook noteBook) {
    this.noteBook = noteBook;
  }

  /**
   * This method override method execute from Command interface for method, that load
   * a notebook from a file.
   * @throws FileNotFoundException - exception, if file not found.
   */
  public void execute() throws FileNotFoundException {
    ArrayList<Note> notes = new ArrayList<Note>();
    NoteBook noteBook = new NoteBook(notes);
    try {
      Scanner scanner = new Scanner(new File("inputNoteBook"));
      StringBuffer data = new StringBuffer();
      while (scanner.hasNext()) {
        String value = scanner.next();
        String stringDate = scanner.nextLine();
        DateFormat format = new SimpleDateFormat("MMMM d, yyyy", Locale.ENGLISH);
        Date date = format.parse(stringDate);
        Note note = new Note(value, date);
        noteBook.getNotes().add(note);
      }
    } catch ( Exception ex ) {
      ex.printStackTrace();
    }
  }
}