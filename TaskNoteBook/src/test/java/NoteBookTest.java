import java.util.ArrayList;
import java.util.List;

import static org.junit.Assert.*;

public class NoteBookTest {

  @org.junit.Test
  public void equalsAndHashCodePositiveTest() {
    Note note = new Note();
    note.setContent("some text");
    note.setName("MMA");
    note.setDate("02.12.2017");
    NoteBook noteBookOne = new NoteBook();
    noteBookOne.setDate("02.12.2017");
    noteBookOne.setName("MMA");
    List<Note> listOfNotes = new ArrayList<>();
    listOfNotes.add(note);
    noteBookOne.setListOfNotes(listOfNotes);
    NoteBook noteBookTwo = new NoteBook();
    noteBookTwo.setDate("02.12.2017");
    noteBookTwo.setName("MMA");
    noteBookTwo.setListOfNotes(listOfNotes);
    assertTrue(noteBookOne.equals(noteBookTwo) && noteBookTwo.equals(noteBookOne));
    assertTrue(noteBookOne.hashCode() == noteBookTwo.hashCode());
  }

  @org.junit.Test
  public void equalsAndHashCodeNegativeTest() {
    Note note = new Note();
    note.setContent("some text");
    note.setName("MMA");
    note.setDate("02.12.2017");
    NoteBook noteBookOne = new NoteBook();
    noteBookOne.setDate("02.12.2017");
    noteBookOne.setName("MMA");
    List<Note> listOfNotes = new ArrayList<>();
    listOfNotes.add(note);
    noteBookOne.setListOfNotes(listOfNotes);
    NoteBook noteBookTwo = new NoteBook();
    noteBookTwo.setDate("29.11.2017");
    noteBookTwo.setName("Billboard");
    noteBookTwo.setListOfNotes(listOfNotes);
    assertFalse(noteBookOne.equals(noteBookTwo) && noteBookTwo.equals(noteBookOne));
    assertFalse(noteBookOne.hashCode() == noteBookTwo.hashCode());
  }

  @org.junit.Test
  public void toStringPositiveTest() {
    assertEquals("NoteBook {date = 'null', name = 'null', listOfNotes = []} ", new NoteBook().toString());
  }

  @org.junit.Test
  public void toStringNegativeTest() {
    assertNotEquals(" ", new NoteBook().toString());
  }
}
