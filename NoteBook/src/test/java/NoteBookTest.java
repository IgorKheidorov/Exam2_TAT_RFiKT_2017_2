import org.junit.Test;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Locale;

import static org.junit.Assert.*;

public class NoteBookTest {
  @Test
  public void hashCodeNoteBook() throws Exception {
    ArrayList<Note> notes = new ArrayList<Note>();
    NoteBook noteBook = new NoteBook(notes);
    assertEquals(noteBook.hashCode(), 32);
  }

  @Test
  public void equalsTwoDifferentNoteBooks() throws Exception {
    ArrayList<Note> notes = new ArrayList<Note>();
    DateFormat df = new SimpleDateFormat("EEE MMM dd kk:mm:ss z yyyy", Locale.ENGLISH);
    Date date =  df.parse("Sat Dec 02 19:30:47 EET 2017");
    notes.add(new Note("test", date));
    NoteBook noteBook = new NoteBook(notes);
    ArrayList<Note> notes1 = new ArrayList<Note>();
    NoteBook noteBook1 = new NoteBook(notes1);
    notes1.add(new Note("test", date));
    assertEquals(noteBook.equals(noteBook1), false);
  }

  @Test
  public void equalsOneNoteBook() throws Exception {
    ArrayList<Note> notes = new ArrayList<Note>();
    DateFormat df = new SimpleDateFormat("EEE MMM dd kk:mm:ss z yyyy", Locale.ENGLISH);
    Date date =  df.parse("Sat Dec 02 19:30:47 EET 2017");
    notes.add(new Note("test", date));
    NoteBook noteBook = new NoteBook(notes);
    assertEquals(noteBook.equals(noteBook), true);
  }

  @Test
  public void toStringNoteBookWithSeveralNotes() throws Exception {
    ArrayList<Note> notes = new ArrayList<Note>();
    DateFormat df = new SimpleDateFormat("EEE MMM dd kk:mm:ss z yyyy", Locale.ENGLISH);
    Date date =  df.parse("Sat Dec 02 19:30:47 EET 2017");
    notes.add(new Note("test", date));
    notes.add(new Note("test", date));
    NoteBook noteBook = new NoteBook(notes);
    assertEquals(noteBook.toString().equals(" test Sat Dec 02 19:30:47 EET 2017 " +
        "test Sat Dec 02 19:30:47 EET 2017" ), true);
  }

}