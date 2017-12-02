import java.io.FileNotFoundException;

/**
 * This is entry point class.
 */
public class EntryPoint {
  public static void main(String[] args) throws Exception {
  String line = "Winter";
  String path = "C:winter.txt";
  int date = 2017;
  Note note  = new Note();
  note.setDate(2017);
  note.setEntry("Winter");
  NoteBook noteBook = new NoteBook();
  noteBook.setNote(note);
  Invoker invoker = new Invoker(new CreatureANewNoteBook(), new AddingNote(noteBook,note),
          new FindingAnEntryInNotepadByContent(noteBook, line), new FindingAnEntryInNotepadByDate(noteBook, date),
          new DemonstrationOfNotes(noteBook), new RealizationOfWritingNoteBookToAFile(noteBook, path),
          new RealizationOfReadingNoteBookFromAFile(path));
  invoker.setAdd();
  invoker.setCreate();
  invoker.setShow();

  }
}
