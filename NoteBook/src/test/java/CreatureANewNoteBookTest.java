import org.testng.annotations.Test;

import static org.testng.Assert.*;

/**
 * This class is a test for CreatureANewNotebook.
 */
public class CreatureANewNoteBookTest {
  @Test
  public void testExecuteIfSizeGrows() throws Exception {
    NoteBook noteBook = new NoteBook();
    Note note = new Note();
    note.setEntry("Winter");
    note.setDate(2017);
    noteBook.setNote(note);
    assertEquals(1,noteBook.getNote().size());
  }

  @Test
  public void testExecuteIfEmpty() throws Exception {
    NoteBook noteBook = new NoteBook();
    assertEquals(0,noteBook.getNote().size());
  }
}