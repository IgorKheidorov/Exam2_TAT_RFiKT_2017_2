import org.testng.annotations.Test;

import static org.testng.Assert.*;

/**
 * This class find notes in Notepad by date.
 */
 class FindingAnEntryInNotepadByDateTest {
   Note note = new Note();
   NoteBook book = new NoteBook();
  @Test (expectedExceptions = Exception.class)
  public void testExecuteIfThrowException() throws Exception {
    FindingAnEntryInNotepadByDate find = new FindingAnEntryInNotepadByDate(book,1);
    note.setEntry("Winter");
    note.setDate(2017);
    book.setNote(note);
    find.execute();
    throw new Exception();
  }

}