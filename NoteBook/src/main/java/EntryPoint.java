import java.io.FileNotFoundException;
import java.text.ParseException;
import java.util.ArrayList;
import java.util.Date;
import java.util.Scanner;

/**
 * This class is entry point for program.
 */

public class EntryPoint {
  public static void main(String[] args) {
    Note note1 = new Note("dddd", new Date());
    ArrayList<Note> notes = new ArrayList<Note>();
    notes.add(note1);
    note1.toString();
    NoteBook noteBook = new NoteBook(notes);
    Scanner scanner = new Scanner(System.in);
    String value = scanner.nextLine();
    String valueForSearchingByValue = scanner.nextLine();
    String valueForSearchingByData = scanner.nextLine();
    Developer developer = new Developer(
        new AddNoteCommand(noteBook, value),
        new CreateNoteBookCommand(),
        new FoundByDateCommand(noteBook, valueForSearchingByData),
        new FoundByValueCommand(noteBook, valueForSearchingByValue),
        new ShowNotesCommand(noteBook),
        new LoadNotebookFromFileCommand(noteBook)
    );
    try {
      developer.createNoteBookRecord();
    } catch (ParseException e) {

    } catch (FileNotFoundException ee) {

    }
  }
}