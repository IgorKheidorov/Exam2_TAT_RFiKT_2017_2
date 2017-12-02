import org.junit.Test;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Locale;

import static org.junit.Assert.assertEquals;

public class AddNoteCommandTest {
  @Test
  public void addNoteToEmptyNotebook() throws Exception {
    ArrayList<Note> notes = new ArrayList<Note>();
    NoteBook noteBook = new NoteBook(notes);
    String value = "test";
    Developer developer = new Developer(
        new AddNoteCommand(noteBook, value),
        new CreateNoteBookCommand(),
        new FoundByDateCommand(noteBook),
        new FoundByValueCommand(noteBook, value),
        new ShowNotesCommand(noteBook),
        new LoadNotebookFromFileCommand(noteBook)
    );
    developer.addNoteRecord();
    assertEquals(noteBook.equals(new Note(value, new Date())), true);
  }
  @Test
  public void addNoteToOneElementNotebook() throws Exception {
    ArrayList<Note> notes = new ArrayList<Note>();
    NoteBook noteBook = new NoteBook(notes);
    DateFormat df = new SimpleDateFormat("EEE MMM dd kk:mm:ss z yyyy", Locale.ENGLISH);
    Date date =  df.parse("Thu Sep 28 20:29:30 JST 2000");
    Note note1 = new Note("test1", date);
    String value = "test";
    Developer developer = new Developer(
        new AddNoteCommand(noteBook, value),
        new CreateNoteBookCommand(),
        new FoundByDateCommand(noteBook),
        new FoundByValueCommand(noteBook, value),
        new ShowNotesCommand(noteBook),
        new LoadNotebookFromFileCommand(noteBook)
    );
    developer.addNoteRecord();
    assertEquals(noteBook.equals(new Note(value, new Date())), true);
  }
  @Test
  public void addNoteToSeveralElementNotebook() throws Exception {
    ArrayList<Note> notes = new ArrayList<Note>();
    NoteBook noteBook = new NoteBook(notes);
    DateFormat df = new SimpleDateFormat("EEE MMM dd kk:mm:ss z yyyy", Locale.ENGLISH);
    Date date =  df.parse("Thu Sep 28 20:29:30 JST 2000");
    Note note1 = new Note("test1", date);
    Note note2 = new Note("test2", date);
    String value = "test";
    Developer developer = new Developer(
        new AddNoteCommand(noteBook, value),
        new CreateNoteBookCommand(),
        new FoundByDateCommand(noteBook),
        new FoundByValueCommand(noteBook, value),
        new ShowNotesCommand(noteBook),
        new LoadNotebookFromFileCommand(noteBook)
    );
    developer.addNoteRecord();
    assertEquals(noteBook.equals(new Note(value, new Date())), true);
  }
}