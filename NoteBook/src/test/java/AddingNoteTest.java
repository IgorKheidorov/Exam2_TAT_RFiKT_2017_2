import static org.testng.Assert.*;

/**
 * This class is a test for AddingNote.
 */
public class AddingNoteTest {
  NoteBook book = new NoteBook();
  Note note = new Note();

  @org.testng.annotations.Test
  public void testExecuteAdditionIfSizeGrows() throws Exception {
    note.setEntry("Winter");
    note.setDate(2017);
    book.setNote(note);
    assertEquals(1,book.getNote().size());
  }

  @org.testng.annotations.Test
  public void testExecuteAdditionIfEmpty() throws Exception {
    int result = 0;
    assertEquals(result,book.getNote().size());
  }
}