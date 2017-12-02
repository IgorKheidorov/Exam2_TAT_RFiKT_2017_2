import org.testng.annotations.Test;

import static org.testng.Assert.*;

/**
 * This is test Note.
 */
public class NoteTest {

  @Test
  public void testEquals() throws Exception {
    Note note = new Note();
    note.setEntry("Winter");
    note.setDate(2017);
    Note noteTwo = new Note();
    noteTwo.setEntry("Winter");
    noteTwo.setDate(2017);
    assertTrue(note.equals(noteTwo));
  }

  @Test
  public void testNotEquals() throws Exception {
    Note note = new Note();
    note.setEntry("oooo");
    note.setDate(2);
    Note noteTwo = new Note();
    noteTwo.setEntry("Winter");
    noteTwo.setDate(2017);
    assertFalse(note.equals(noteTwo));
  }

  @Test (expectedExceptions = Exception.class)
  public void testException() throws Exception {
    Note note = new Note();
    Note noteTwo = new Note();
    noteTwo.setEntry("Winter");
    noteTwo.setDate(2017);
    throw new Exception();
  }


}