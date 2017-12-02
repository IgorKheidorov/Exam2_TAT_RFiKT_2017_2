import SkuratovichSiarhey.by.Note;
import SkuratovichSiarhey.by.NoteBook;

import static org.junit.Assert.*;

/**
 * Created by siarhey on 02.12.17.
 */
public class NoteBookTest {
  @org.junit.Test
  public void addNote() throws Exception {
  }

  @org.junit.Test
  public void checkFindByContentWithOneNote() throws Exception {
    NoteBook noteBook = new NoteBook("My SkuratovichSiarhey.by.NoteBook");
    Note note = new Note("first note", "something good");
    noteBook.addNote(note);
    assertEquals("total found: 1\n1)\nfirst note\n" + note.getDate(), noteBook.findByContent("something good"));
  }

  @org.junit.Test
  public void checkFindByContentWithThreeNotes() throws Exception {
    NoteBook noteBook = new NoteBook("My SkuratovichSiarhey.by.NoteBook");
    Note note1 = new Note("first note", "something good");
    noteBook.addNote(note1);
    Note note2 = new Note("second note", "something bad");
    noteBook.addNote(note2);
    Note note3 = new Note("third note", "something so-so");
    assertEquals("total found: 1\n2)\nsecond note\n" + note2.getDate(), noteBook.findByContent("something bad"));
  }

  @org.junit.Test
  public void checkFindByContentWith2EqualNotesContent() throws Exception {
    NoteBook noteBook = new NoteBook("My SkuratovichSiarhey.by.NoteBook");
    Note note1 = new Note("first note", "something good");
    noteBook.addNote(note1);
    Note note2 = new Note("second note", "something good");
    noteBook.addNote(note2);
    Note note3 = new Note("third note", "something so-so");
    noteBook.addNote(note3);
    assertEquals("total found: 2\n" +
            "1)\n" +
            "first note\n" +
            note1.getDate() + "\n" +
            "2)\n" +
            "second note\n" +
            note2.getDate(), noteBook.findByContent("something good"));
  }

  @org.junit.Test
  public void checkFindByDateWithThreeNotes() throws Exception {
    NoteBook noteBook = new NoteBook("My SkuratovichSiarhey.by.NoteBook");
    Note note1 = new Note("first note", "something good");
    noteBook.addNote(note1);
    Note note2 = new Note("second note", "something bad");
    noteBook.addNote(note2);
    Note note3 = new Note("third note", "something so-so");
    noteBook.addNote(note3);
    assertEquals("2)\n" +
            "second note\n" +
            "something bad", noteBook.findByDate("something bad"));
  }
}