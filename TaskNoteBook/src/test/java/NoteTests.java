import static org.junit.Assert.*;

public class NoteTests {

  @org.junit.Test
  public void equalsAndHashCodePositiveTest() {
    Note noteOne = new Note();
    noteOne.setContent("some text");
    noteOne.setName("MMA");
    noteOne.setDate("02.12.2017");
    Note noteTwo = new Note();
    noteTwo.setContent("some text");
    noteTwo.setName("MMA");
    noteTwo.setDate("02.12.2017");
    assertTrue(noteOne.equals(noteTwo) && noteTwo.equals(noteOne));
    assertTrue(noteOne.hashCode() == noteTwo.hashCode());
  }

  @org.junit.Test
  public void equalsAndHashCodeNegativeTest() {
    Note noteOne = new Note();
    noteOne.setContent("dna");
    noteOne.setName("Billboard");
    noteOne.setDate("27.11.2017");
    Note noteTwo = new Note();
    noteTwo.setContent("some text");
    noteTwo.setName("MMA");
    noteTwo.setDate("02.12.2017");
    assertFalse(noteOne.equals(noteTwo) && noteTwo.equals(noteOne));
    assertFalse(noteOne.hashCode() == noteTwo.hashCode());
  }

  @org.junit.Test
  public void toStringPositiveTest() {
    assertEquals("Note {date = 'null', name = 'null', content = 'null'} ", new Note().toString());
  }

  @org.junit.Test
  public void toStringNegativeTest() {
    assertNotEquals(" ", new Note().toString());
  }
}
