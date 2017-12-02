import org.testng.annotations.Test;

import static org.testng.Assert.*;

/**
 * This class is a test for DemonstrationOfNotes.
 */
public class DemonstrationOfNotesTest {
  NoteBookConsoleView show = new NoteBookConsoleView();

  @Test
  public void testExecuteShowEmpty() throws Exception {
    Note note = new Note();
    show.print(note);
  }
}