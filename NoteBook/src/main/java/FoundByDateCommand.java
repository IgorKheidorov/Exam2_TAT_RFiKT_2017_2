import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Locale;

/**
 * This class realize found by date method in notebook.
 */

public class FoundByDateCommand implements Command {
  NoteBook noteBook;
  String stringDate;
  public FoundByDateCommand(NoteBook noteBook, String stringDate) {
    this.stringDate = stringDate;
    this.noteBook = noteBook;
  }

  /**
   * This method override method execute from Command interface for method, that
   * found note by date.
   * @throws ParseException - exception for date parse.
   */

  public void execute() throws ParseException{
    DateFormat df = new SimpleDateFormat("EEE MMM dd kk:mm:ss z yyyy", Locale.ENGLISH);
    Date date = df.parse(stringDate);
    String foundNode = null;
    for (int i = 0; i < noteBook.getNotes().size(); i++) {
      if (noteBook.getNotes().get(i).getDate().equals(date)) {
        foundNode = noteBook.getNotes().get(i).toString();
      }
    }
    if (foundNode == null) {
      System.out.println("There isn't note with your date");
    } else {
      System.out.println(foundNode + " it is your note.");
    }
  }
}