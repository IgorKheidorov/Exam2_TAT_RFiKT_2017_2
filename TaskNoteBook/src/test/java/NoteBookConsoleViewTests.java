import java.util.ArrayList;
import java.util.List;

import static org.junit.Assert.*;

public class NoteBookConsoleViewTests extends OutputTest {

  @org.junit.Test
  public void printOneNotePositiveTest() {
    Note note = new Note();
    note.setContent("some text");
    note.setName("MMA");
    note.setDate("02.12.2017");
    NoteBook noteBook = new NoteBook();
    noteBook.setDate("02.12.2017");
    noteBook.setName("MMA");
    List<Note> listOfNotes = new ArrayList<>();
    listOfNotes.add(note);
    noteBook.setListOfNotes(listOfNotes);
    new NoteBookConsoleView().print(noteBook, 0);
    assertEquals("Note {date = '02.12.2017', name = 'MMA', content = 'some text'} ", output.toString());
  }

  @org.junit.Test
  public void printOneNoteNegativeTest() {
    NoteBook noteBook = new NoteBook();
    List<Note> listOfNotes = new ArrayList<>();
    listOfNotes.add(new Note());
    noteBook.setListOfNotes(listOfNotes);
    new NoteBookConsoleView().print(noteBook, 0);
    assertNotEquals("", output.toString());
  }

  @org.junit.Test(expected = ArrayIndexOutOfBoundsException.class)
  public void printOneNoteExceptionTest() {
    new NoteBookConsoleView().print(new NoteBook(), 5);
  }

  @org.junit.Test
  public void printSeveralNotesPositiveTest() {
    Note noteOne = new Note();
    noteOne.setContent("dna");
    noteOne.setName("Billboard");
    noteOne.setDate("27.11.2017");
    Note noteTwo = new Note();
    noteTwo.setContent("some text");
    noteTwo.setName("MMA");
    noteTwo.setDate("02.12.2017");
    Note noteThree = new Note();
    noteThree.setContent("cool");
    noteThree.setName("MAMA");
    noteThree.setDate("01.12.2017");
    NoteBook noteBook = new NoteBook();
    noteBook.setDate("02.12.2017");
    noteBook.setName("shows");
    List<Note> listOfNotes = new ArrayList<>();
    listOfNotes.add(noteOne);
    listOfNotes.add(noteTwo);
    listOfNotes.add(noteThree);
    noteBook.setListOfNotes(listOfNotes);
    new NoteBookConsoleView().print(noteBook, 1, 2);
    assertEquals("Note {date = '02.12.2017', name = 'MMA', content = 'some text'} " +
            "Note {date = '01.12.2017', name = 'MAMA', content = 'cool'} ", output.toString());
  }

  @org.junit.Test
  public void printSeveralNotesNegativeTest() {
    NoteBook noteBook = new NoteBook();
    List<Note> listOfNotes = new ArrayList<>();
    listOfNotes.add(new Note());
    listOfNotes.add(new Note());
    listOfNotes.add(new Note());
    noteBook.setListOfNotes(listOfNotes);
    new NoteBookConsoleView().print(noteBook, 1, 2);
    assertNotEquals("", output.toString());
  }

  @org.junit.Test(expected = ArrayIndexOutOfBoundsException.class)
  public void printSeveralNotesExceptionTest() {
    new NoteBookConsoleView().print(new NoteBook(), 0, 5, -4);
  }

  @org.junit.Test
  public void printNoteBookPositiveTest() {
    Note noteOne = new Note();
    noteOne.setContent("dna");
    noteOne.setName("Billboard");
    noteOne.setDate("27.11.2017");
    Note noteTwo = new Note();
    noteTwo.setContent("some text");
    noteTwo.setName("MMA");
    noteTwo.setDate("02.12.2017");
    Note noteThree = new Note();
    noteThree.setContent("cool");
    noteThree.setName("MAMA");
    noteThree.setDate("01.12.2017");
    NoteBook noteBook = new NoteBook();
    noteBook.setDate("02.12.2017");
    noteBook.setName("shows");
    List<Note> listOfNotes = new ArrayList<>();
    listOfNotes.add(noteOne);
    listOfNotes.add(noteTwo);
    listOfNotes.add(noteThree);
    noteBook.setListOfNotes(listOfNotes);
    new NoteBookConsoleView().print(noteBook);
    assertEquals("NoteBook {date = '02.12.2017', name = 'shows', listOfNotes = [Note {date = '27.11.2017', name = 'Billboard', content = 'dna'} , " +
            "Note {date = '02.12.2017', name = 'MMA', content = 'some text'} , " +
            "Note {date = '01.12.2017', name = 'MAMA', content = 'cool'} ]} ", output.toString());
  }

  @org.junit.Test
  public void printNoteBookNegativeTest() {
    NoteBook noteBook = new NoteBook();
    List<Note> listOfNotes = new ArrayList<>();
    listOfNotes.add(new Note());
    listOfNotes.add(new Note());
    listOfNotes.add(new Note());
    noteBook.setListOfNotes(listOfNotes);
    new NoteBookConsoleView().print(noteBook);
    assertNotEquals("", output.toString());
  }
}
