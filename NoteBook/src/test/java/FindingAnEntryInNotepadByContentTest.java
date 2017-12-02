import org.testng.annotations.Test;

import static org.testng.Assert.*;

/**
 * This class is a test for DemonstrationOfNotes.
 */
public class FindingAnEntryInNotepadByContentTest {
  NoteBook book = new NoteBook();
  Note note = new Note();

  @Test (expectedExceptions = Exception.class)
  public void testExecuteIfThereIsNoSuchContent() throws Exception {
    FindingAnEntryInNotepadByContent find = new FindingAnEntryInNotepadByContent(book,"Summer");
    note.setEntry("Winter");
    note.setDate(2017);
    book.setNote(note);
    find.execute();
    throw new Exception();
  }

}