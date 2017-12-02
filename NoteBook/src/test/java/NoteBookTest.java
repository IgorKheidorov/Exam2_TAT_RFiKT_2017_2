import org.testng.annotations.Test;

import static org.testng.Assert.*;

/**
 * This class test notebook.
 */
public class NoteBookTest {
  NoteBook noteBook = new NoteBook();
  NoteBook book = new NoteBook();

  @Test
  public void testEquals() throws Exception {
    Note note = new Note();
    note.setEntry("oooo");
    note.setDate(2);
    noteBook.setNote(note);
    book.setNote(note);
    assertTrue(book.equals(noteBook));
  }

  @Test (expectedExceptions = Exception.class)
  public void testException() throws Exception {
    Note note = new Note();
    noteBook.setNote(note);
    book.setNote(note);
    throw new Exception();
  }

  @Test
  public void testNotEquals() throws Exception {
    Note note = new Note();
    note.setEntry("oooo");
    note.setDate(2);
    noteBook.setNote(note);
    assertFalse(book.equals(noteBook));
  }
}